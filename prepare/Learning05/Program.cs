using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");


        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Yellow", 5, 7));
        shapes.Add(new Circle("Pink", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }

    }
}