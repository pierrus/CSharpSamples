using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 123;
            object obj = i;
            Console.WriteLine(obj.GetType().Name);
            
            Console.ReadLine();
            i = 456;
            Console.WriteLine(i);
            Console.WriteLine(obj);

            int i2 = (int)obj;
            Console.WriteLine(i2);

            //String != string
            //Int32 != int
        }
    }
}
