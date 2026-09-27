using System;
using System.Threading;

string text = "Luca";

for(int i = 0; i < text.Length; i++)
{
    System.Console.Write(text[i]);
    Thread.Sleep(150);
}
System.Console.WriteLine();

for(int i = text.Length - 1; i >= 0; i--)
{
    System.Console.Write(text[i]);
    Thread.Sleep(150);
}
System.Console.WriteLine();
