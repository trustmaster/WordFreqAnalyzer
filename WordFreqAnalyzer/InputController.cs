// InputController.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Parametric class providing text retrieval from generic source
    /// </summary>
    /// <typeparam name="ReaderType">Source data reader type</typeparam>
    /// <typeparam name="ExtractorType">Extra data extractor type</typeparam>
    /// <typeparam name="ExtractedDataType">Extra data type</typeparam>
    /// <typeparam name="CleanserType">Initial text processor type</typeparam>
    public class InputController<ReaderType, ExtractorType, ExtractedDataType, CleanserType> : IGetText
        where ReaderType : Reader, new()
        where ExtractorType : IExtractor<ExtractedDataType>, new()
        where CleanserType : Processor<string>, new()
    {
        protected Reader reader;
        protected ExtractorType extractor;
        protected ExtractedDataType extdata;
        protected Processor<string> cleanser;

        public InputController()
        {
            extractor = new ExtractorType();
            reader = new ReaderType();
            cleanser = new CleanserType();
        }

        public InputController(string path) : this()
        {
            reader.Path = path;
        }

        public string Path
        {
            get
            {
                return reader.Path;
            }
            set
            {
                reader.Path = value;
            }
        }

        public ExtractedDataType Data
        {
            get
            {
                // if (extdata == null) throw Exception();
                return extdata;
            }
        }

        public string GetText()
        {
            string text = reader.GetText();
            if (text == "") return "";
            extdata = extractor.Extract(text);
            cleanser.Component = new StringFlow(text);
            return cleanser.Process();
        }
    }
}
