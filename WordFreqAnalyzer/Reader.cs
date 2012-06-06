// Reader.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Abstract text reader
    /// </summary>
    public abstract class Reader: IGetText
    {
        protected string path;

        public Reader()
        {
            // Nothing
        }

        public Reader(string path)
        {
            this.path = path;
        }

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        public abstract string GetText();
    }
}
