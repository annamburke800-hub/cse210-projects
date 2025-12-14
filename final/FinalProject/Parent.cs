using System;

public class Parent : Person
{
    public Parent(string name, double money, DateTime lastAllowanceGiven) : base(name, money, lastAllowanceGiven){}

    public override void Allowance(List<Chore> chores, string name)
    {
         double totalAllowance= 0;
        for (int i = 0; i < chores.Count; i++)
        {
            if (chores[i].GetLastDone() > _lastAllowanceGiven && chores[i].GetWhoDid() == name)// & (DateTime.Today-chores[i].GetLastDone()).Days < 9999 )
            {
                totalAllowance += chores[i].GetWorth();
            }
        }
        _money -= totalAllowance;
        if (totalAllowance > 0)
        {
            _lastAllowanceGiven = DateTime.Today;
        }
        
    }

     public override string GetStringRepresentation()
    {
        string details = $"Parent|{GetName()}|{_money}|{_lastAllowanceGiven}";
        return details;
    }
}