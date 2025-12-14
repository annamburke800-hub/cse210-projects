using System;

public class Child : Person
{  
    public Child(string name, double money, DateTime lastAllowanceGiven) : base(name, money, lastAllowanceGiven){}

    public override void Allowance(List<Chore> chores, string name)
    {
        double totalAllowance= 0;
        for (int i = 0; i < chores.Count; i++)
        {
            if (chores[i].GetLastDone() > _lastAllowanceGiven && chores[i].GetWhoDid() == name)
            {
                totalAllowance += chores[i].GetWorth();
            }
        }
        Console.WriteLine($"{GetName()} will earn ${totalAllowance.ToString("0.00")}.");
        _money += totalAllowance;
        if (totalAllowance > 0)
        {
            _lastAllowanceGiven = DateTime.Today;
        }
        
    }

    public override string GetStringRepresentation()
    {
        string details = $"Child|{GetName()}|{_money}|{_lastAllowanceGiven}";
        return details;
    }
}