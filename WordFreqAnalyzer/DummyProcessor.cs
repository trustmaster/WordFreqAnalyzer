// DummyProcessor.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Dummy string processor that does't change the string
    /// being passed through the decorator chain
    /// </summary>
    public class DummyProcessor : Processor<string>
    {
        public DummyProcessor() { }

        public DummyProcessor(IDataFlow<string> component) : base(component) { }

        public override string Process()
        {
            string text = base.Process();
            return text;
        }
    }
}
