// StringFlow.cs
namespace TextAnalyzer
{
    /// <summary>
    /// String data stream with processing support
    /// </summary>
    public class StringFlow : IDataFlow<string>
    {
        protected string item;

        public StringFlow() { }

        public StringFlow(string item)
        {
            this.item = item;
        }

        public string Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        public string Process()
        {
            return item;
        }
    }
}
