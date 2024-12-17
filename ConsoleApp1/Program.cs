using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Введіть x:");
            string inputX = Console.ReadLine();
            Console.WriteLine("Введіть y:");
            string inputY = Console.ReadLine();
            Console.WriteLine("Введіть z:");
            string inputZ = Console.ReadLine();

            int x, y, z;

            if (!int.TryParse(inputX, out x))
            {
                Console.WriteLine("Некоректне значення для x.");
                Console.ReadLine();
                return;
            }

            if (!int.TryParse(inputY, out y))
            {
                Console.WriteLine("Некоректне значення для y.");
                Console.ReadLine();
                return;

            }

            if (!int.TryParse(inputZ, out z))
            {
                Console.WriteLine("Некоректне значення для z.");
                Console.ReadLine();
                return;

            }


            double res1 = Math.Pow(x - 1, 1.0 / 3);
            double res2 = Math.Pow(y + res1, 1.0 / 4);
            double res3 = 2 * (Math.Abs(x + z));

            double res = Math.Log10(x) * (res2/res3);



            Console.WriteLine("Результат: " + Math.Round(res, 4));
            Console.ReadLine();
        }
    }
}
