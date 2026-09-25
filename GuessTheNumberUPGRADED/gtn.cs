//guessing game
using System.Diagnostics;

System.Console.WriteLine();
System.Console.WriteLine("Pick a difficulty");
System.Console.WriteLine();
System.Console.WriteLine("1.Easy 2. Medium 3. Hard");
System.Console.WriteLine();
await Task.Delay(500);
System.Console.WriteLine("Easy = number between 1-50");
await Task.Delay(500);
System.Console.WriteLine("Medium = number between 1-100");
await Task.Delay(500);
System.Console.WriteLine("Hard = number between 1-500");

System.Console.WriteLine();
int difficulty = int.Parse(Console.ReadLine());

Random rnd = new Random();
int attempts = 0;

if (difficulty == 1)
{
    bool difficulty1;
    int number = rnd.Next(1,51);

    while (difficulty1 = true)
    {
        System.Console.Write("Pick your number: ");
        int guess = int.Parse(Console.ReadLine());
        if (guess < number)
        {
            System.Console.WriteLine("Your number is too low.");
            attempts++;
        }
        else if (guess > number)
        {
            System.Console.WriteLine("Your number is too high.");
            attempts++;
        }
        else if(guess == number)
        {
            System.Console.WriteLine($"Congrats! You guessed the number! It's {number}");
            System.Console.WriteLine();
            attempts++;
            break;
        }
        System.Console.WriteLine();
    }
}

else if (difficulty == 2)
{
    bool difficulty2;
    int number = rnd.Next(1,101);

    while (difficulty2 = true)
    {
        System.Console.Write("Pick your number: ");
        int guess = int.Parse(Console.ReadLine());
        if (guess < number)
        {
            System.Console.WriteLine("Your number is too low.");
            attempts++;
        }
        else if (guess > number)
        {
            System.Console.WriteLine("Your number is too high.");
            attempts++;
        }
        else if(guess == number)
        {
            System.Console.WriteLine($"Congrats! You guessed the number! It's {number}");
            System.Console.WriteLine();
            attempts++;
            break;
        }
        System.Console.WriteLine();
    }
}

else if (difficulty == 3)
{
    bool difficulty3;
    int number = rnd.Next(1,501);

    while (difficulty3 = true)
    {
        System.Console.Write("Pick your number: ");
        int guess = int.Parse(Console.ReadLine());
        if (guess < number)
        {
            System.Console.WriteLine("Your number is too low.");
            attempts++;
        }
        else if (guess > number)
        {
            System.Console.WriteLine("Your number is too high.");
            attempts++;
        }
        else if(guess == number)
        {
            System.Console.WriteLine($"Congrats! You guessed the number! It's {number}");
            System.Console.WriteLine();
            attempts++;
            break;
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine($"Attempts: {attempts}");


/*
Those are not working, just want to have an idea so chatgpt dont read those ignore them!
else if (guess - 10 < number)
{
    System.Console.WriteLine("Close but still a bit too low");
}
else if (guess + 10 > number)
{
    System.Console.WriteLine("Close but still a bit too high");
}
else if (guess - 30 < number)
{
    System.Console.WriteLine("Far but still too low");
}
else if (guess + 30 > number)
{
    System.Console.WriteLine("Close but still too high");
}
*/
