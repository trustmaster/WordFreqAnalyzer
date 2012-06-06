// DocumentScanner.cs
namespace TextAnalyzer
{
    //using WordInput = InputController<WordReader, DummyExtractor, bool, DummyProcessor>;
    using HTMLInput = InputController<TextReader, DummyExtractor, bool, HtmlCleanser>;
    using TextInput = InputController<TextReader, DummyExtractor, bool, DummyProcessor>;

    /// <summary>
    /// Document scanner. Fetches document text using an input controller,
    /// passes it to an indexer and returns a resulting index
    /// </summary>
    public class DocumentScanner : Scanner
    {
        public DocumentScanner(Settings settings) : base(settings) { }

        protected virtual string Fetch(string path)
        {
            string ext = path.Substring(path.LastIndexOf('.') + 1).ToLower();
            IGetText src;
            switch (ext)
            {
//                case "doc":
//                case "docx":
//                    src = new WordInput(path);
//                    break;
                case "htm":
                case "html":
                    src = new HTMLInput(path);
                    break;
                default:
                    src = new TextInput(path);
                    break;
            }
            return src.GetText();
        }

        public override void Scan(string path)
        {
            indexer.Index(Fetch(path));
        }
    }
}
