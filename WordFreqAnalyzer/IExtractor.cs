// IExtractor.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Interface for an extractor out of a string
    /// </summary>
    /// <typeparam name="OutType">Extracted data type</typeparam>
    public interface IExtractor<OutType>
    {
        OutType Extract(string text);
    }
}
