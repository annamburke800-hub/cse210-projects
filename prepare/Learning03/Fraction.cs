using System.Globalization;

public class Fraction
{
    private double _numerator;
    private double _denominator;

    public Fraction()
    {
        _numerator = 1;

        _denominator = 1;
    }

    public Fraction(double num)
    {
        _numerator = num;
        _denominator = 1;
    }
    
    public Fraction(double num, double den)
    {
        _numerator = num;

        _denominator = den;
    }



    public string GetFractionString()
    {
        string fracstring = $"{_numerator}/{_denominator}";
        return fracstring;
    }

    public double GetDecimalValue()
    {
        double fracdouble = _numerator / _denominator;
        return fracdouble;
    }
}