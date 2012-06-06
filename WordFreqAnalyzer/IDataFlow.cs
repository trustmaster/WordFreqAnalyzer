// IDataFlow.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Processible data stream interface
    /// </summary>
    /// <typeparam name="T">Stream data type</typeparam>
    public interface IDataFlow<T>
    {
        T Process();
    }
}
