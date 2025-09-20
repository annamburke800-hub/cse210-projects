using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first Nname? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine();
        Console.Write($"My name is {lname}, {fname} {lname}.");
    }
}