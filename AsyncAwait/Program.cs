using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Collections;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task<int>> tasks = new List<Task<int>>();
            
            int t1, t2;
            System.Threading.ThreadPool.GetAvailableThreads(out t1, out t2);
            Console.WriteLine("Available threads {0}/{1}", t1, t2);

            for (int i = 0; i < 10; i++)
            {
                Task<int> charCountTask = i % 2 == 0 ?
                    CountCharacters("https://www.reddit.com/") : CountCharacters("https://stackoverflow.com/");
                tasks.Add(charCountTask);
            }

            Task taskA = Task.Run(() => Loop());

            System.Threading.Thread.Sleep(1000);

            System.Threading.ThreadPool.GetAvailableThreads(out t1, out t2);
            Console.WriteLine("Available threads {0}/{1}", t1, t2);

            Task.WaitAll(tasks.ToArray());
            taskA.Wait();

            tasks.ForEach(task => Console.WriteLine("Result {0}", task.Result));

            
        }

        private static void Loop()
        {
            Console.WriteLine("Started loop in thread {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);

            var j = 0;
            for(int i = 0;i<1000000000;++i)
            {
                j = i;
            }

            Console.WriteLine("Finished loop in thread {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
        }

        static async Task<int> CountCharacters(String url)
        {
            var client = new HttpClient();

            Console.WriteLine("Started in thread {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);

            var page = await client.GetStringAsync(url);

            //Console.WriteLine("Finished in thread {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);

            return page.Length;
        }
    }
}
