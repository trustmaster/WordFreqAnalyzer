// CharFilter.cs
using System.Text;

namespace TextAnalyzer
{
    /// <summary>
    /// Text processor that removes all characters which are
    /// not present in target alphabet
    /// </summary>
    public class CharFilter : Processor<string>
    {
        public CharFilter() { }

        public CharFilter(IDataFlow<string> component) : base(component) { }

        public override string Process()
        {
            string text = base.Process();
            StringBuilder sb = new StringBuilder(text.Length);
            char c, b = '\u0000';
            for (int i = 0; i < text.Length; i++)
            {
                c = text[i];
                if (c == '\u0020'                       // space
                    || c > '\u002F' && c < '\u003A'     // 0-9
                    || c > '\u0040' && c < '\u005b'     // A-Z
                    || c > '\u0060' && c < '\u007b'     // a-z
                    || c >= '\u00C0' && c < '\u017f'    // Latin
                    || c >= '\u0391' && c < '\u03ff'    // Greek
                    || c >= '\u0400' && c < '\u0500')  // Cyrillic
                {
                    sb.Append(c);
                }
                else
                {
                    c = '\u0020';
                    if (b != c)
                        sb.Append(c);
                }
                b = c;
            }
            return sb.ToString();
        }
    }
}
