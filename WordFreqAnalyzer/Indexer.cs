// Indexer.cs
using System.Collections.Generic;

namespace TextAnalyzer
{
    /// <summary>
    /// Frequency index builder for a string
    /// </summary>
    public class Indexer
    {
        protected Index index;
        protected int minLength;
        protected List<string> stopwords;

        public Indexer()
        {
            index = new Index();
            minLength = 3;
            stopwords = null;
        }

        public int MinLength
        {
            get
            {
                return minLength;
            }
            set
            {
                minLength = value;
            }
        }

        public void SetStopWords(string data)
        {
            Tokenizer tok = new Tokenizer(new StringFlow(data));
            stopwords = tok.Tokenize();
        }

        public void Index(string text)
        {
            if (text == "") return;
            Tokenizer proc = new Tokenizer(new CharFilter(new StringFlow(text)));
            List<string> words = proc.Tokenize();
            foreach (string word in words)
            {
                if (word.Length >= minLength && (stopwords == null || !stopwords.Contains(word)))
                    index.Inc(word);
            }
        }

        public Index GetIndex()
        {
            return index;
        }
    }
}
