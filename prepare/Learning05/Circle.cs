using System;
using System.Formats.Asn1;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
        SetColor(color);
    }
    
    public override double GetArea()
    {
        double area = Math.PI * _radius*_radius;
        return area;
    }
}