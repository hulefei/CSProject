using System.Collections;

namespace CSProject.Chapter06
{
    public class IterationSample : IEnumerable
    {
        public readonly object[] values;
        public readonly int startingPoint;

        public IterationSample(object[] values, int startingPoint)
        {
            this.values = values;
            this.startingPoint = startingPoint;
        }

        public IEnumerator GetEnumerator()
        {
            return new IterationSampleIterator(this);
        }
    }
}