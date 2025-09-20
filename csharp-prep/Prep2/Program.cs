using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What score did you get? ");
        string sscore = Console.ReadLine();
        int score = Convert.ToInt32(sscore);
        string letterGrade;
        string porm;
        // porm stands for Plus OR Minus

        if (score > 93 || score < 60)
        {
            porm = "";
        }
        else if (score % 10 >= 7)
        {
            porm = "+";
        }
        else if (score % 10 <= 3)
        {
            porm = "-";
        }
        else
        {
            porm = "";
        }

        if (score >= 90)
        {
            letterGrade = "A";
        }
        else if (score >= 80)
        {
            letterGrade = "B";
        }
        else if (score >= 70)
        {
            letterGrade = "C";
        }
        else if (score >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You scored a {score}, so your grade is {letterGrade}{porm}");

        if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }
    }
}