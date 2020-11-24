using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHomework
{
    class Task3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
             var rawch = Console.ReadLine();
            if (char.TryParse(rawch, out  char ch))
            {
                var resultcode = (int)ch + 1;
                Console.WriteLine((char)resultcode);

            }
            

            else 
            {
                Console.WriteLine("Некорректные данные");
            }
        }
    }
}
