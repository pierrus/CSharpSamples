using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TasksSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting in thread {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();

            List<Task> allTasks = new List<Task>();
            for (int i = 0; i < 50; i++)
            {
                allTasks.Add(Run(i));
            }

            Task.WaitAll(allTasks.ToArray());
        }

        static Task Run(int i)
        {
            return Task.Factory.StartNew(() => {
                System.Threading.Thread.Sleep(400);
                Console.WriteLine("Done {0} in thread {1}", i, System.Threading.Thread.CurrentThread.ManagedThreadId);
            }, TaskCreationOptions.LongRunning);
        }
    }
}
