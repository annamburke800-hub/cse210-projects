using System;

public abstract class Person
{
    private string _name;
    private double _money;

    public Person(string name, double money)
    {
        _name = name;
        _money = money;
    }

    public abstract void Allowance();

    public string GetName()
    {
        return _name;
    }
}