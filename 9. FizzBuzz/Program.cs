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
            Console.Write("Nr: ");
            int nr = int.Parse(Console.ReadLine());
            int fizzbuzz = 0;
            int fizz = 0;
            int buzz = 0;
            int normal = 0;
            for (int i = 1; i <= nr; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    fizzbuzz++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }
                else
                {
                    Console.WriteLine(i);
                    normal++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Fizzbuzz numbers: {fizzbuzz}");
            Console.WriteLine($"Fizz numbers: {fizz}");
            Console.WriteLine($"Buzz numbers: {buzz}");
            Console.WriteLine($"Normal numbers: {normal}");
        }
    }
}

