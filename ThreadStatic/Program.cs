using System;
using System.Threading;

namespace ThreadStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ParallelWorker worker = new ParallelWorker();
                var newThread = worker.Run();
            }

            ParallelWorker currentThreadWorker = new ParallelWorker();
            currentThreadWorker.Run();

            ParallelWorker.Countdown.Wait();
        }
    }
}
