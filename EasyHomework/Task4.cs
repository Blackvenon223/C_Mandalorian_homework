using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHomework
{
    class Task4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите a ");
            var rawA =  Console.ReadLine();
            Console.WriteLine("Введите b ");
            var rawB =  Console.ReadLine();
            Console.WriteLine("Введите c");
            var rawC = Console.ReadLine();

            if (int.TryParse(rawA,out int a) & int.TryParse(rawB, out int b) & int.TryParse(rawC, out int c))
            {
                var D = b*b - (4 * a * c);
                if (D > 0)
                {
                    var x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    var x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"1 корень {x1}    2 корень {x2}  ");
                }
                if (D < 0) { 
                Console.WriteLine("корней нет");

                }
                if (D == 0)
                {
                    var x = -b / (2 * a);
                    Console.WriteLine($"корень {x}");
                }




            }
            else
            {
                Console.WriteLine("Введите корректные данные");
            }
        }  
    }
}
