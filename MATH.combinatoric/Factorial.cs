using System;
using System.Text;


namespace Combinatoric
{
    public class Factorial
    {
        public static int Compute(int f)
        {
            // Console.WriteLine("Hi, this little program fast compute your factorials");
            //Console.WriteLine("Привет, эта маленькая программа быстро вычислит твои факториалы");
            Console.OutputEncoding = Encoding.UTF8;
            //считаем факториал */
            int sum = 1;
            //Console.Write("Введите число факториала: ");
            //f = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"Your factorial {f}! = ");
            //Console.Write($"Твой факториал {f}! = ");
            if (f < 0)
                Console.WriteLine($"Значение {f}! не корректно, введите число N >= 0");
            //Console.WriteLine($"Your factorial {f}! not correct, input N >= 0");
            else if (f > 0)
            {
                for (int i = 2; i <= f; i++) //цикл начинается с двойки по причине того,
                                             //что любое целое положительно число при умножении на 1 не меняется,
                                             //экономим одну итерацию цикла
                {
                    sum = sum * i;
                    //if (i < f)
                    //    Console.Write($"{i}*");
                    //else
                    //    Console.Write($"{i}");
                }

                //Console.Write($" = {sum}");
            }

            else if (f == 0)
                Console.WriteLine($"1");
            return sum;
        }
    } 
}
