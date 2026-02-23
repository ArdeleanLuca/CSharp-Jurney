using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MoneyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Money exchange*/
            Console.WriteLine("Welcome to the Money Exchange!!");
            Console.Write("Ce doresti sa schimbi? (Eur sau Ron?): ");
            string question = Console.ReadLine().ToLower();

            if (question == "ron")
            {
                Console.Write("Suma pe care doresti sa o schimbi: ");
                float total_ron = float.Parse(Console.ReadLine());
                float total_sum_ron = total_ron / 5.10f;
                Console.Write($"{total_ron:F2} in ron = {total_sum_ron:F2} eur");
            }

            else if (question == "eur")
            {
                Console.Write("Suma pe care doresti sa o schimbi: ");
                float total_eur = float.Parse(Console.ReadLine());
                float total_sum_eur = total_eur * 5.10f;
                Console.Write($"{total_eur:F2} in eur = {total_sum_eur:F2} ron");
            }

            else
            {
                Console.Write("Ai introdus simbolul gresit!");
            }
        }
    }
}
