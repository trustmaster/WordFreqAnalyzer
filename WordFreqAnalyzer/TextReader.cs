// TextReader.cs
using System.IO;

namespace TextAnalyzer
{
    /// <summary>
    /// Reads text from local files
    /// </summary>
    public class TextReader : Reader
    {
        public TextReader() : base() { }

        public TextReader(string path) : base(path) { }

        public override string GetText()
        {
            StreamReader sr = new StreamReader(path);
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }
    }
}
