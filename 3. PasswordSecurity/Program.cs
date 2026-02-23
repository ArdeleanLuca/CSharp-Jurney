using System;

namespace PasswordSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Password Security System ---");
            string password = "cat214";
            Console.WriteLine("Hint: The password is 'cat' + numbers from 1 to 1000. Good luck!");

            bool guessing = true;
            int attempts = 0;

            while (guessing)
            {
                attempts++;

                Console.Write("Enter password: ");
                string passwordGuessing = Console.ReadLine();

                if (passwordGuessing == password)
                {
                    Console.WriteLine($"Congratulations! You guessed the password in {attempts} attempts!");
                    guessing = false;
                }
                else
                {
                    Console.WriteLine("Wrong password! Try again.");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
