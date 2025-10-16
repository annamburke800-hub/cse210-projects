using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction a = new Fraction();

        Fraction b = new Fraction(5);

        Fraction c = new Fraction(3, 4);
        
        Fraction f = new Fraction(1, 3);

        Console.WriteLine(a.GetDecimalValue());
        Console.WriteLine(a.GetFractionString());

        Console.WriteLine(b.GetDecimalValue());
        Console.WriteLine(b.GetFractionString());

        Console.WriteLine(c.GetDecimalValue());
        Console.WriteLine(c.GetFractionString());

        Console.WriteLine(f.GetDecimalValue());
        Console.WriteLine(f.GetFractionString());

        
       

    }
}