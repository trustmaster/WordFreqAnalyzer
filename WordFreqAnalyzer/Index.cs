// Index.cs
using System.Collections.Generic;

namespace TextAnalyzer
{
    /// <summary>
    /// Index entity as word-frequency pair collection.
    /// Can find words with min and max frequency.
    /// Supports multithreading.
    /// </summary>
    public class Index : Dictionary<string, int>
    {
        private object sharedLock = new object();

        public int Inc(string key)
        {
            lock (sharedLock)
            {
                if (!ContainsKey(key))
                    Add(key, 0);
                return ++this[key];
            }
        }

        public KeyValuePair<string, int> GetMaxFreqPair()
        {
            KeyValuePair<string, int> res = new KeyValuePair<string,int>("", 0);
            foreach (KeyValuePair<string, int> pair in this)
                if (pair.Value > res.Value)
                    res = pair;
            return res;
        }

        public KeyValuePair<string, int> GetMinFreqPair()
        {
            KeyValuePair<string, int> res = new KeyValuePair<string, int>("", int.MaxValue);
            foreach (KeyValuePair<string, int> pair in this)
                if (pair.Value < res.Value)
                    res = pair;
            return res;
        }
    }
}
