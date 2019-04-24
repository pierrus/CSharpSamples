using System;
using System.Threading;

namespace ThreadStatic
{
    public class ParallelWorker
    {
        [ThreadStatic]
        static double randomValue;

        public static CountdownEvent Countdown = new CountdownEvent(11);

        private static Random rand = new Random();

        public ParallelWorker()
        {
        }

        public Thread Run()
        {
            Thread newThread = new Thread(new ThreadStart(this.GenerateRandomNumbers));
            newThread.Name = newThread.ManagedThreadId.ToString();
            newThread.Start();
            
            return newThread;
        }

        public void GenerateRandomNumbers()
        {
            randomValue = rand.NextDouble();
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Random value in thread {0} is {1}", Thread.CurrentThread.Name, randomValue);
            }

            Countdown.Signal();
        }
    }
}
