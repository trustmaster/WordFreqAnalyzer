// KeyValueComparer.cs
using System.Collections.Generic;
using System.ComponentModel;

namespace TextAnalyzer
{
    using T = KeyValuePair<string, int>;
    /// <summary>
    /// Word-frequency pair comparer for sorting
    /// </summary>
    public class KeyValueComparer : IComparer<T>
    {
        private ListSortDirection sortDirection;

        public KeyValueComparer(ListSortDirection direction)
        {
            sortDirection = direction;
        }

        public KeyValueComparer(PropertyDescriptor property, ListSortDirection direction) : this(direction) { }

        public int Compare(T xWord, T yWord)
        {
            if (sortDirection == ListSortDirection.Ascending)
            {
                return CompareAscending(xWord, yWord);
            }
            else
            {
                return CompareDescending(xWord, yWord);
            }
        }

        private int CompareAscending(T xValue, T yValue)
        {
            if (xValue.Value > yValue.Value)
                return 1;
            else if (xValue.Value == yValue.Value)
                return 0;
            else
                return -1;
        }

        private int CompareDescending(T xValue, T yValue)
        {
            return CompareAscending(xValue, yValue) * -1;
        }
    }
}
