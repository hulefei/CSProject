using System;

namespace CSProject.Chapter06
{
    public class DisposeObject : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("DisposeObject Dispose");
        }
    }
}