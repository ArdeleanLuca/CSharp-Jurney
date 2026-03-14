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
            Console.WriteLine(num);
            bool running = true;

            while (running)
            {
                int guessing = int.Parse(Console.ReadLine());
                int near = num - 5;
                int far = num + 10;

                 if (guessing == num)
                 {
                    Console.WriteLine("Felicitari, ai ghicit numarul!");
                    running = false;
                 }

                else if (guessing >= near)
                {
                    Console.WriteLine("Foarte aproape");
                }

                else if(guessing <= far)
                {
                    Console.WriteLine("Departe");
                }

                else
                {
                    Console.Write("Mai incearca!: ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Multumesc ca te-ai jucat");
        }
    }
}
