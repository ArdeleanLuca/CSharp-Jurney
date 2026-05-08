using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numar: ");
            string numInp = Console.ReadLine();
            int nr = 0;
            bool success = int.TryParse(numInp, out nr);
            Console.WriteLine($"{nr}, {success}");
            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("Continui?: ");
                string question = Console.ReadLine();

                if (question == "y")
                {
                    Console.Write("Alege numarul: ");
                    numInp = Console.ReadLine();
                    success = int.TryParse(numInp, out nr);
                    Console.WriteLine($"{nr}, {success}");
                }
                else if (question == "q")
                {
                    isRunning = false;
                    Console.WriteLine("Thanks for playing");
                }
                else
                {
                    Console.WriteLine("Wrong keys");
                }
            }
        }
    }
}

