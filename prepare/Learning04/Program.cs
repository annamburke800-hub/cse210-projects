using System;

class Program
{
    static void Main(string[] args)
    {
       
        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());
        Console.WriteLine();

        MathAssignment b = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(b.GetSummary());
        Console.WriteLine(b.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment c = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(c.GetWritingInformation());

    }
}