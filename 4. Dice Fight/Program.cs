using System;
using System.Runtime.InteropServices;

namespace PasswordSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------ Barbut ------");
                Console.WriteLine("Cum te numesti?");
                string name = Console.ReadLine().ToUpper();


                while (true)
                {
                    Console.WriteLine("Vrei sa incepi? (Enter / q): ");
                    string question = Console.ReadLine().ToLower();


                    if (question == "q")
                    {
                        Console.WriteLine("Multumesc ca te-ai jucat!");
                        return;
                    }

                    Random dice1 = new Random();

                    if (question == "")
                    {
                        int zar1 = dice1.Next(1, 7);
                        int zar2 = dice1.Next(1, 7);

                        Console.WriteLine($"{name}: {zar1}");
                        Console.WriteLine();
                        Console.WriteLine("Enter to roll the dice...");
                        Console.ReadLine();
                        Console.WriteLine($"Calculatorul: {zar2}");
                        Console.WriteLine();

                        if (zar1 > zar2) { Console.WriteLine($"{name} a castigat!"); }
                        else if (zar2 > zar1) { Console.WriteLine("Calculatorul a castigat"); }
                        else { Console.WriteLine("Felicitari amandurora! Egalitate :) "); }

                    }

                    else
                    {
                        Console.WriteLine("Incorrect symbol");
                    }

                }
            }
        }
    }
}
