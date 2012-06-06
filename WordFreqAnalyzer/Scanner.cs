// Scanner.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Abstract controller, using input unit
    /// and indexer for frequency analysis
    /// </summary>
    public abstract class Scanner
    {
        protected Indexer indexer;

        public Scanner(Settings settings)
        {
            indexer = new Indexer();
            indexer.MinLength = settings.MinLength;
            if (settings.UseStopWords)
            {
                TextReader rdr = new TextReader("stopwords.txt");
                indexer.SetStopWords(rdr.GetText());
            }
        }

        public abstract void Scan(string path);

        public Index GetIndex()
        {
            return indexer.GetIndex();
        }
    }
}
