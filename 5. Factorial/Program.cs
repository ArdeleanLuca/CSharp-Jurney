using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //factorial
        int factorial = 1;
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}
