using System;

public class Child : Person
{
    
    public Child(string name, double money) : base(name, money){}

    public override void Allowance()
    {
        throw new NotImplementedException();
    }
}