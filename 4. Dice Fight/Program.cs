using System;
using System.Runtime.InteropServices;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------ Dice Game ------");
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine().ToUpper();

                while (true)
                {
                    Console.WriteLine("Do you want to start? (Enter / q to quit): ");
                    string question = Console.ReadLine().ToLower();

                    if (question == "q")
                    {
                        Console.WriteLine("Thanks for playing!");
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
                        Console.WriteLine($"Computer: {zar2}");
                        Console.WriteLine();

                        if (zar1 > zar2) { Console.WriteLine($"{name} won!"); }
                        else if (zar2 > zar1) { Console.WriteLine("The Computer won!"); }
                        else { Console.WriteLine("Congratulations to both! It's a tie :) "); }
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
