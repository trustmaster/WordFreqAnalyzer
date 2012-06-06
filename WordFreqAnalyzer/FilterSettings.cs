// FilterSettings.cs
using System.ComponentModel;

namespace TextAnalyzer
{
    /// <summary>
    /// Stores index filter settings for a chart
    /// </summary>
    public class FilterSettings
    {
        private ListSortDirection direction;
        private int count;

        public FilterSettings(ListSortDirection direction, int count)
        {
            this.direction = direction;
            this.count = count;
        }

        public FilterSettings() : this(ListSortDirection.Descending, 5) { }

        public ListSortDirection Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
