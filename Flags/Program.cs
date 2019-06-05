using System;

namespace Flags
{
    class Program
    {
        static void Main(string[] args)
        {
            Skills hisSkills = Skills.Azure | Skills.Angular | Skills.CSharp;

            Console.WriteLine("Has Angular skills {0}", hisSkills.HasFlag(Skills.Angular));
            Console.WriteLine("Has Azure skills {0}", hisSkills.HasFlag(Skills.Azure));
            Console.WriteLine("Has FSharp skills {0}", hisSkills.HasFlag(Skills.FSharp));

            Console.WriteLine("Binary value {0}", Convert.ToString((int)hisSkills, 2));
        }
    }
}