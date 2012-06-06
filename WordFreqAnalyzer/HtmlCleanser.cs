// HtmlCleanser.cs
using System.Text.RegularExpressions;

namespace TextAnalyzer
{
    /// <summary>
    /// Extracts HTML document title and body,
    /// gets plain text out of them
    /// </summary>
    public class HtmlCleanser : Processor<string>
    {
        public HtmlCleanser() { }

        public HtmlCleanser(IDataFlow<string> component) : base(component) { }

        public override string Process()
        {
            string text = base.Process();
            string title = "";
            // Use only title and body, strip tags
            Regex r = new Regex("<title>(.+?)</title>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            title = r.Match(text).Groups[1].Value;
            r = new Regex("<body.*?>(.+?)</body>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            text = r.Match(text).Groups[1].Value;
            r = new Regex("<(script|style).*?>.+?</\\1>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            text = r.Replace(text, string.Empty);
            r = new Regex("<!\\[CDATA\\[.+?\\]\\]>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            text = r.Replace(text, string.Empty);
            r = new Regex("<!--.+?-->", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            text = r.Replace(text, string.Empty);
            r = new Regex("<.+?>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            text = r.Replace(text, string.Empty);
            r = new Regex("&.+?;", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            text = r.Replace(text, string.Empty);
            return title + " " + text;
        }
    }
}
