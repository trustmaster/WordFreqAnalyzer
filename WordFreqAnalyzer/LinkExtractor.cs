// LinkExtractor.cs
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TextAnalyzer
{
    /// <summary>
    /// Extracts links from HTML document
    /// </summary>
    public class LinkExtractor : IExtractor<List<string>>
    {
        public List<string> Extract(string text)
        {
            List<string> links = new List<string>();
            if (text != "")
            {
                Regex r = new Regex("<body.*?>(.+?)</body>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                string body = r.Match(text).Groups[1].Value;
                r = new Regex("href\\s*=\\s*('|\")?([^\"'\\s>]+)\\1", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                for (Match m = r.Match(body); m.Success; m = m.NextMatch())
                {
                    links.Add(m.Groups[2].Value.Replace("&amp;", "&"));
                }
            }
            return links;
        }
    }
}
