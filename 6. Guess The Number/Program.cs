using System.ComponentModel.Design;
namespace everything_project
{
    internal class GuessingNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Am ales un numar de la 1 la 100, ghiceste-l: ");
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            bool running = true;

            while (running == true)
            {
                int guessing = int.Parse(Console.ReadLine());
                int difference = Math.Abs(num - guessing);

                if (guessing == num)
                {
                    Console.WriteLine("Felicitari, ai ghicit numarul!");
                    running = false;
                }

                else if (difference <= 5)
                {
                    Console.WriteLine("Esti foarte aproape (fierbinte)!");
                }

                else if (difference <= 15)
                {
                    Console.WriteLine("Esti destul de aproape (caldut).");
                }

                else if (guessing < num)
                {
                    Console.WriteLine("Prea mic! Mai încearcă.");
                }

                else 
                {
                    Console.WriteLine("Prea mare! Mai încearcă.");
                }

            }

            Console.WriteLine();
            Console.WriteLine("Multumesc ca te-ai jucat");
        }
    }
}
