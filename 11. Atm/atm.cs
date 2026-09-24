using System;

//atm

bool menu = true;
System.Console.WriteLine("(1)Balance");
System.Console.WriteLine("(2)Deposit");
System.Console.WriteLine("(3)Withdraw");
System.Console.WriteLine();

float balance = 0f;


while (menu)
{
    System.Console.Write("What do you want to do?: ");
    int option = int.Parse(Console.ReadLine());
    if(option == 1)
    {
        System.Console.WriteLine($"Your balance is: ${balance}");
        System.Console.WriteLine();
    }
    else if(option == 2)
    {
        System.Console.Write("How much money would you like to deposit?: ");
        float deposit = float.Parse(Console.ReadLine());
        balance = balance + deposit;
        System.Console.WriteLine($"Your new balance is: ${balance}");
        System.Console.WriteLine();
    }
    else if(option == 3)
    {
        System.Console.Write("How much money would you like to withdraw?: ");
        float withdrawAmount = float.Parse(Console.ReadLine());

        if(withdrawAmount > balance)
        {
           System.Console.WriteLine("I'm sorry but you dont have enough money! Try again later!"); 
           System.Console.WriteLine();
        }
        else
        {
            balance = balance - withdrawAmount;
            System.Console.WriteLine($"Your new balance is: ${balance}");
            System.Console.WriteLine();
        }
    }
}


/*
    else if(option == 3)
    {
        System.Console.Write("How much money would you like to withdraw?: ");
        float withdraw = float.Parse(Console.ReadLine());
        withdraw = balance - withdraw;
        if(withdraw < 0)
        {
           System.Console.WriteLine("I'm sorry but you dont have enough money! Try again later!"); 
           System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine($"Your new balance is: ${withdraw}");
            System.Console.WriteLine();
        }
    }

*/
