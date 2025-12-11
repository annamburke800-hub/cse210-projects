using System;

public abstract class Person
{
    private string _name;
    protected double _money;
    protected DateTime _lastAllowanceGiven;

    public Person(string name, double money, DateTime lastAllowanceGiven)
    {
        _name = name;
        _money = money;
        _lastAllowanceGiven = lastAllowanceGiven;
    }

    public abstract void Allowance(List<Chore> chores);
    //get date!!!! hidden variable of last time allowance was given and only give allowance for AFTER that date!!!!

    public string GetName()
    {
        return _name;
    }
    
    public double GetMoney()
    {
        return _money;
    }
}