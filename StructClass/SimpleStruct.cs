using System;

namespace StructClass
{
    public struct SimpleStruct
    {
        public SimpleStruct(int a)
        {
            A = a;
        }

        public readonly int A;

        public SimpleClass MyProperty = new SimpleClass();
    }
}