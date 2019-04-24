using System;
using System.Collections;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // foreach (object o in GetValues())
            // {
            //     Console.Write(o);
            // }

            int i = 0;
            foreach (ulong fibValue in GetFibonacci())
            {
                Console.WriteLine(fibValue);
                if (i++ == 50)
                    break;
            }
        }

        static public IEnumerable GetValues()
        {
            yield return "Yield";
            yield return " c'est";
            yield return " rigolo.";
        }

        static public IEnumerable GetFibonacci()
        {
            ulong previousElement = 0;
            ulong currentElement = 1;

            while (true)
            {
                ulong nextElement = currentElement + previousElement;
                yield return nextElement;
                previousElement = currentElement;
                currentElement = nextElement;
            }
        }
    }
}
