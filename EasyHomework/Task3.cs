using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHomework
{
    class Task3
    {




        public static void Solve(int A, int B, int C)
        {

            if (A != 0)
            {
                int D = B * B - 4 * A * C;
                Console.WriteLine(D);
                if (D < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");

                }
                else if (D == 0)
                {
                    Console.WriteLine(D);
                    int T = -B / (2 * A);
                    Console.WriteLine(T);
                    if (T > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Первый Корень >>>>>>{Math.Sqrt(T)} Второй Корень>>>>>>{-Math.Sqrt(T)}");
                    }
                    else if (T == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" Корень >>>>> 0");

                    }
                }
                else if (D > 0)
                {
                    Console.WriteLine(D);
                    double T1 = (-B + Math.Sqrt(D)) / (2 * A);
                    double T2 = (-B - Math.Sqrt(D)) / (2 * A);
                    Console.WriteLine(T1);
                    if (T1 > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Первый Корень >>>>>>{Math.Sqrt(T1)} Второй Корень>>>>>>{-Math.Sqrt(T1)}");
                    }
                    if (T2 > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Первый Корень >>>>>>{Math.Sqrt(T2)} Второй Корень>>>>>>{-Math.Sqrt(T2)}");
                    }

                }

                
            }

        }


    

        public static void Main(string[] args)
        {


            int A, B, C;
            Console.WriteLine("Введите A");
            while (!int.TryParse(Console.ReadLine(), out  A))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ВВедите корректные данные!!!");
                Console.ResetColor();
            }
            Console.WriteLine("Введите B");
           
            while (!int.TryParse(Console.ReadLine(), out B))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ВВедите корректные данные!!!");
                Console.ResetColor();
            }
            
            Console.WriteLine("Введите C");
            while (!int.TryParse(Console.ReadLine(), out  C))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ВВедите корректные данные!!!");
                Console.ResetColor();
            }



            
            Solve(A,B,C);

          
          

        }
    }
}

