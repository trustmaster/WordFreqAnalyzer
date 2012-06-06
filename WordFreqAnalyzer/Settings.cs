// Settings.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Settings object for scanner initialization
    /// </summary>
    public class Settings
    {
        private int minLength;
        private int numThreads;
        private int maxLinks;
        private bool useStopWords;

        public Settings(int min_length, int num_threads, int max_links, bool use_stopwords)
        {
            minLength = min_length;
            numThreads = num_threads;
            maxLinks = max_links;
            useStopWords = use_stopwords;
        }

        public Settings() : this(1, 1, 1000, false) { }

        public int MinLength
        {
            get
            {
                return minLength;
            }
            set
            {
                if (value > 0)
                    minLength = value;
            }
        }

        public int NumThreads
        {
            get
            {
                return numThreads;
            }
            set
            {
                if (value > 0 && value < 1000)
                    numThreads = value;
            }
        }

        public int MaxLinks
        {
            get
            {
                return maxLinks;
            }
            set
            {
                if (value > 0)
                    maxLinks = value;
            }
        }

        public bool UseStopWords
        {
            get
            {
                return useStopWords;
            }
            set
            {
                useStopWords = value;
            }
        }
    }
}
