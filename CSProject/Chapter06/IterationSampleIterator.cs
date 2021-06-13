using System;
using System.Collections;

namespace CSProject.Chapter06
{
    public class IterationSampleIterator : IEnumerator
    {
        private readonly IterationSample m_parent;
        private int m_position;

        internal IterationSampleIterator(IterationSample parent)
        {
            m_parent = parent;
            m_position = -1;
        }
        
        public bool MoveNext()
        {
            if (m_position != m_parent.values.Length)
            {
                m_position++;
            }

            return m_position < m_parent.values.Length;
        }

        public void Reset()
        {
            m_position = -1;
        }

        public object Current
        {
            get
            {
                if (m_position == -1 || m_position == m_parent.values.Length)
                {
                    throw new InvalidOperationException();
                }

                var index = m_position + m_parent.startingPoint;
                index = index % m_parent.values.Length;
                return m_parent.values[index];
            }
        }
    }
}