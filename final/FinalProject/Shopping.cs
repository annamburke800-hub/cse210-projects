using System;

public class Shopping : Chore
{
    private double _cost;

    public Shopping(string title, string description, int howOften, DateTime lastDone, double worth, string whoDid, double cost) : base(title, description, howOften, lastDone, worth, whoDid)
    {
        _cost = cost;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"--{_title}--\n{_description}");
        LastDone();
        NextDo();
        DateTime today = DateTime.Today;
        if ((today-GetLastDone()).Days < 9999)
        {
            Console.WriteLine($"Last done by {_whoDid}\nMost Recent Cost: ${_cost.ToString("0.00")}");
        }
        
    }

    public override void DoChore(Person person)
    {
        Console.Write("What was the cost of this trip?\n$");
        double cost = double.Parse(Console.ReadLine());
        _cost = cost;

        base.DoChore(person);

    }

    public override string GetStringRepresentation()
    {
        string details = $"{base.GetStringRepresentation()}|{_cost}";
        return details;
    }

    
}