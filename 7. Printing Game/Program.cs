using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What do u wanna print?: ");
            string print = Console.ReadLine();
            Console.Write("How many times?: ");
            int times = int.Parse(Console.ReadLine());

            bool isRunning = true;

            while (isRunning)
            {
                for(int i = 1; i <= times; i++)
                {
                    Console.WriteLine(print);
                }
                Console.Write("Continue? (y or n): ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y")
                {
                    Console.WriteLine();
                    Console.Write("What do u wanna print?: ");
                    print = Console.ReadLine();
                    Console.Write("How many times?: ");
                    times = int.Parse(Console.ReadLine());
                }
                else if(answer == "n")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
                else
                {
                    Console.Write("Invalid character!");
                    break;
                }

            }
        }
    }
}
