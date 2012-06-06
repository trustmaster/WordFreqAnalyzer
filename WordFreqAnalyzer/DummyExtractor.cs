// DummyExtractor.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Placebo class implementing IExtractor
    /// </summary>
    public class DummyExtractor : IExtractor<bool>
    {
        public bool Extract(string text)
        {
            // Does nothing
            return true;
        }
    }
}
