using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // CSE 210
        // Anna Burke
        // List practice
        
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int numbinput = 1;
        float sum = 0;
        int largestnumb = int.MinValue;
        int smallPosNumb = int.MaxValue;
        while (numbinput != 0)
        {
            Console.Write("Input a number for the list: ");
            numbinput = int.Parse(Console.ReadLine());
            if (numbinput != 0)
            {
                numbers.Add(numbinput);
            }
            if (numbinput > largestnumb)
            {
                largestnumb = numbinput;
            }
            if (numbinput > 0)
            {
                if (numbinput < smallPosNumb)
                {
                    smallPosNumb = numbinput;
                }
            }
            sum += numbinput;
        }
        
        Console.WriteLine($"Sum:{sum}");
        Console.WriteLine($"Average:{sum / numbers.Count}");
        Console.WriteLine($"Largest Number: {largestnumb}");
        Console.WriteLine($"Smallest positive number: {smallPosNumb}");
        numbers.Sort();
        Console.WriteLine("Sorted list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}