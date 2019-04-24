using System;

namespace StructClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            SimpleStruct simpleStruct = new SimpleStruct { A = 1 };
            Console.WriteLine(simpleStruct.A);
            UpdateStruct(simpleStruct);
            Console.WriteLine(simpleStruct.A);

            Console.ReadLine();

            SimpleClass simpleClass = new SimpleClass { A = 1 };
            Console.WriteLine(simpleClass.A);
            UpdateClass(simpleClass);
            Console.WriteLine(simpleClass.A);
        }

        static void UpdateStruct(SimpleStruct s)
        {
            s.A = 2;
        }

        static void UpdateClass(SimpleClass s)
        {
            s.A = 2;
        }

        public class SimpleClass
        {
            public int A { get; set; }
            public float B { get; set; }
        }

        public struct SimpleStruct
        {
            public SimpleStruct(int a, float b)
            {
                A = a;
                B = b;                
            }

            public readonly int A;
            public readonly float B;

            //public SimpleClass MyProperty = new SimpleClass();
        }
    }
}
