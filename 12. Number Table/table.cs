using System;

//tabla inmultirii prin for 

System.Console.Write("Number for the table: ");
int numInp = int.Parse(Console.ReadLine());
System.Console.Write("When should the table stop?: ");
int numStop = int.Parse(Console.ReadLine());
System.Console.WriteLine();

for(int i = 1; i <= numStop; i++)
{
    System.Console.WriteLine($"{numInp} x {i} = {numInp * i}");
}
System.Console.WriteLine();
