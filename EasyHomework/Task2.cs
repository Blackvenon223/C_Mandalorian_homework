using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHomework
{
    class Task2

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число");
            var RawFirstNumber = Console.ReadLine();
            Console.WriteLine("Введите 2 число");
            var RawSecondNumber = Console.ReadLine();

            if (int.TryParse(RawFirstNumber, out int FirstNumber) & int.TryParse(RawSecondNumber,out int SecondNumber ))
            {
                if (SecondNumber  == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!!!");
                }
                else
                {
                    var result = FirstNumber / SecondNumber;
                    Console.WriteLine($"Результат >>> {result}");
                }
            }
            else
            {
                Console.WriteLine("Введите корректные данные");
               
            }

        }
    }
}
