using System;

namespace Flags
{
    [Flags]
    public enum Skills
    {
        Dotnet = 0,
        CSharp = 1,
        FSharp = 2,
        TypeScript = 0b100,
        Angular = 8,
        React = 16,
        Docker = 32,
        Azure = 64
    }
}