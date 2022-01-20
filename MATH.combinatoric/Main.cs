using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatoric
{   
    public class Menu
    {
        private static readonly int f=5;

        static public void Main()
        {
            Combinations.Compute();
            Accommodation.Compute();
            int result = Factorial.Compute(f);
            Console.WriteLine("##########################################");
            Console.WriteLine($"Значение факториала {f}! = {result}");
        }

    }
}
