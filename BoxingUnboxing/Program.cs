using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            int i2 = 123;
            
            //Boxing (implicite)
            object obj = i;
            object obj2 = i;

            Console.WriteLine("Are value types equals {0}", i == i2);
            Console.WriteLine("Are reference types equals after boxing {0}", obj == obj2);

            Console.ReadLine();

            obj = obj2;
            Console.WriteLine("Are reference types equals {0}", obj == obj2);
            
            Console.ReadLine();

            //Unboxing (explicite)
            int i3 = (int)obj;
            int i4 = (int)obj2;

            Console.WriteLine("Are value types equals after unboxing {0}", i3 == i4);
        }
    }
}
