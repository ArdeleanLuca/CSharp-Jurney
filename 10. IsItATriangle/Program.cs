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
            Console.Write("L1: ");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("L2: ");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("L3: ");
            int l3 = Convert.ToInt32(Console.ReadLine());

            int sumguest = l1 + l2 + l3;
            int rightsum = 180;

            string question = (sumguest == rightsum && l1 > 0 && l2 > 0 && l3 > 0 ) ? "Valid" : "Invalid";
            Console.WriteLine(question);
        }
    }
}
