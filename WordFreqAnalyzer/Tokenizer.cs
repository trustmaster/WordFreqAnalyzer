// Tokenizer.cs
using System.Collections.Generic;

namespace TextAnalyzer
{
    /// <summary>
    /// String flow processing chain node,
    /// splitting it into words
    /// </summary>
    public class Tokenizer : Processor<string>
    {
        public Tokenizer(IDataFlow<string> component) : base(component) { }

        public List<string> Tokenize()
        {
            string text = base.Process();
            string[] tmp = text.Split(' ');
            List<string> res = new List<string>();
            string t;
            foreach (string s in tmp)
            {
                t = s.Trim().ToLower();
                if (t != "")
                    res.Add(t);
            }
            return res;
        }
    }
}
