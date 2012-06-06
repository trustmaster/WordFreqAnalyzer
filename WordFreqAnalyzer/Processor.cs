// Processor.cs
namespace TextAnalyzer
{
    /// <summary>
    /// Abstract data stream processor
    /// </summary>
    /// <typeparam name="T">Stream data type</typeparam>
    public abstract class Processor<T> : IDataFlow<T>
    {
        protected IDataFlow<T> component;

        public Processor() { }

        public Processor(IDataFlow<T> component)
        {
            this.component = component;
        }

        public IDataFlow<T> Component
        {
            get
            {
                return component;
            }
            set
            {
                component = value;
            }
        }

        public virtual T Process()
        {
            return component.Process();
        }
    }
}
