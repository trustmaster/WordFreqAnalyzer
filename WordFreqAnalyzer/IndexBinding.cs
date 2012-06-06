// IndexBinding.cs
using System.Collections.Generic;
using System.ComponentModel;

namespace TextAnalyzer
{
    using T = KeyValuePair<string, int>;
    /// <summary>
    /// Index class adapter for BidingList interface
    /// with sorting support
    /// </summary>
    public class IndexBinding : BindingList<T>
    {
        private readonly Index data;
        private bool isSorted;
        private ListSortDirection order;

        public IndexBinding(Index data)
        {
            this.data = data;
            order = ListSortDirection.Descending;
            Reset();
        }

        public void Reset()
        {
            bool oldRaise = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            try
            {
                Clear();
                foreach (T pair in data)
                    Add(pair);
            }
            finally
            {
                isSorted = false;
                RaiseListChangedEvents = oldRaise;
                ResetBindings();
            }
        }

        public void Sort(ListSortDirection direction)
        {
            List<T> items = this.Items as List<T>;
            if (items != null)
            {
                KeyValueComparer pc = new KeyValueComparer(direction);
                items.Sort(pc);
                isSorted = true;
                order = direction;
            }
            else
            {
                isSorted = false;
            }
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public bool IsSorted
        {
            get { return isSorted; }
        }

        public ListSortDirection Order
        {
            get { return order; }
        }

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            Sort(direction);
        }

        protected override bool IsSortedCore
        {
            get { return isSorted; }
        }

        protected override void RemoveSortCore()
        {
            Reset();
            isSorted = false;
        }
    }
}
