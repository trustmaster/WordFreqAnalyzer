// IndexFilter.cs
using System.Collections.Generic;
using System.ComponentModel;

namespace TextAnalyzer
{
    /// <summary>
    /// Gets limited set of pairs from the source index
    /// binding according to filter settings
    /// </summary>
    public class IndexFilter
    {
        private FilterSettings settings;

        public IndexFilter(FilterSettings initSettings)
        {
            settings = initSettings;
        }

        public Index Filter(IndexBinding binding)
        {
            Index res = new Index();
            bool wasSorted = binding.IsSorted;
            ListSortDirection prevOrder = binding.Order;
            if (!wasSorted || prevOrder != settings.Direction)
                binding.Sort(settings.Direction);
            int lim = settings.Count > binding.Count ? binding.Count : settings.Count;
            int i = 0;
            foreach (KeyValuePair<string, int> pair in binding)
            {
                if (i >= lim)
                    break;
                res.Add(pair.Key, pair.Value);
                i++;
            }
            if (!wasSorted)
                binding.Reset();
            else if (prevOrder != settings.Direction)
                binding.Sort(prevOrder);
            return res;
        }
    }
}
