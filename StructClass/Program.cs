using System;

namespace StructClass
{
    class Program
    {
        static void Main(string[] args)
        {            
            SimpleStruct simpleStruct = new SimpleStruct(1);
            Console.WriteLine("Struct prop A avant update {0}", simpleStruct.A);
            UpdateStruct(simpleStruct);
            Console.ReadLine();
            Console.WriteLine("Struct prop A après update {0}", simpleStruct.A);

            Console.ReadLine();

            SimpleClass simpleClass = new SimpleClass(1);
            Console.WriteLine("Class prop A avant update {0}", simpleClass.A);
            UpdateClass(simpleClass);
            Console.ReadLine();
            Console.WriteLine("Class prop A après update {0}",simpleClass.A);
        }

        static void UpdateStruct(SimpleStruct s)
        {
            s.A = 2;
        }

        static void UpdateClass(SimpleClass s)
        {
            s.A = 2;
        }
    }
}
