using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Nr: ");
        int number = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}
