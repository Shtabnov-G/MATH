using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatoric
{
    public class Accommodation
    {
        public static int Compute()
        {
            //считаем Размещения 
            Console.WriteLine("Программа считает количество Размещений А");
            Console.WriteLine("##########################################");
            Console.WriteLine();
            Console.Write ("Введите нижний показатель n =  ");
            int An = Convert.ToInt32(Console.ReadLine());
            Console.Write ("Введите верхний пoказатель m =  ");
            int Am = Convert.ToInt32(Console.ReadLine());
            int A = Factorial.Compute(An)/Factorial.Compute(An-Am);
            Console.WriteLine($"Количество размещений А = {A} ");
            Console.WriteLine();
            return A;
        }
    }
}
