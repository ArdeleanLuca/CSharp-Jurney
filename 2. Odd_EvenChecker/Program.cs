using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OddEvenChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ODD / Even checker!");
            Console.WriteLine();
            
            bool is_runing = true;

            while (is_runing)
            {
                Console.Write("Enter the number you want to check! (0 to quit): ");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("Thanks for playing!");
                    is_runing = false;
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else if (number % 2 != 0)
                {
                    Console.WriteLine("Odd");
                }
            }
        }
    }
}
