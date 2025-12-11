using System;

public class Child : Person
{  
    public Child(string name, double money, DateTime lastAllowanceGiven) : base(name, money, lastAllowanceGiven){}

    public override void Allowance(List<Chore> chores)
    {
        double totalAllowance= 0;
        for (int i = 0; i < chores.Count; i++)
        {
            if (chores[i].GetLastDone() > _lastAllowanceGiven)
            {
                totalAllowance += chores[i].GetWorth();
            }
        }
        Console.WriteLine($"{GetName()} will earn ${totalAllowance.ToString("0.00")}.");
        _money += totalAllowance;
        _lastAllowanceGiven = DateTime.Today;
    }
}