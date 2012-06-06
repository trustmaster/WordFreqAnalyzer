// SiteScanner.cs
using System;
using System.Collections.Generic;
using System.Threading;

namespace TextAnalyzer
{
    using WebInput = InputController<HttpReader, LinkExtractor, List<string>, HtmlCleanser>;
    /// <summary>
    /// Controller that scans websites.
    /// Uses input and indexer units.
    /// Supports multithreading for the entire process:
    /// from text retrieval up to index building.
    /// </summary>
    public class SiteScanner : Scanner
    {
        protected volatile List<string> scannedLinks;
        protected volatile List<string> inProgress;
        protected Uri mainUri;
        protected int maxLinks;
        private Object resLock;

        public SiteScanner(Settings settings)
            : base(settings)
        {
            scannedLinks = new List<string>();
            inProgress = new List<string>();
            maxLinks = settings.MaxLinks;
            int i, minIOC, maxIOC;
            ThreadPool.GetMinThreads(out i, out minIOC);
            ThreadPool.GetMaxThreads(out i, out maxIOC);
            ThreadPool.SetMinThreads(settings.NumThreads, minIOC);
            ThreadPool.SetMaxThreads(settings.NumThreads, maxIOC);
            resLock = new Object();
        }

        public int ScannedUrlCount
        {
            get
            {
                return scannedLinks.Count;
            }
        }

        public override void Scan(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                mainUri = new Uri(url);
                string current = mainUri.ToString();
                inProgress.Add(current);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.ScanUrl), (object) current);
                do
                {
                    Thread.Sleep(100);
                    lock (resLock)
                    {
                        if (inProgress.Count == 0 || (maxLinks != 0 && scannedLinks.Count >= maxLinks))
                            break;
                    }
                }
                while (true);
            }
            else
            {
                // throw Exception
            }
        }

        protected void ScanUrl(object urlObject)
        {
            string url = (string)urlObject;
            WebInput src = new WebInput(url);
            string text = src.GetText();
            if (text != "")
            {
                List<string> links = src.Data;
                Uri uri = new Uri(url);
                ProcessLinks(links, uri);
                indexer.Index(text);
            }
            lock (resLock)
            {
                scannedLinks.Add(url);
                inProgress.Remove(url);
            }
        }

        protected void ProcessLinks(List<string> links, Uri base_uri)
        {
            Uri uri;
            string absUrl;
            foreach (string link in links)
            {
                if (Uri.IsWellFormedUriString(link, UriKind.RelativeOrAbsolute))
                {
                    uri = (Uri.IsWellFormedUriString(link, UriKind.Relative)) ? new Uri(base_uri, link) : new Uri(link);
                    if (uri.Host == mainUri.Host && uri != base_uri)
                    {
                        absUrl = uri.ToString();
                        lock (resLock)
                        {
                            int totalLinks = scannedLinks.Count + inProgress.Count;
                            if ((maxLinks == 0 || totalLinks < maxLinks)
                                && !scannedLinks.Contains(absUrl)
                                && !inProgress.Contains(absUrl))
                            {
                                inProgress.Add(absUrl);
                                ThreadPool.QueueUserWorkItem(new WaitCallback(this.ScanUrl), (object) absUrl);
                            }
                        }
                    }
                }
            }
        }
    }
}
