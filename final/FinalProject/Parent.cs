using System;

public class Parent : Person
{
    public Parent(string name, double money) : base(name, money){}

    public override void Allowance()
    {
        throw new NotImplementedException();
    }
}