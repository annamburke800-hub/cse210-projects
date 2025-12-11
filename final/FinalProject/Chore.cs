using System;

public  class Chore
{
    protected string _title;
    protected string _description;
    private int _howOften;
    private DateTime _lastDone;
    private double _worth;
    protected Person _whoDid;

    public Chore(string title, string description, int howOften, DateTime lastDone, double worth, Person whoDid)
    {
        _title = title;
        _description = description;
        _howOften = howOften;
        _lastDone = lastDone;
        _worth = worth;
        _whoDid = whoDid;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"--{_title}--\n{_description}");
        LastDone();
        NextDo();
        Console.WriteLine($"Last done by {_whoDid.GetName()}");
    }

    public void LastDone()
    {
        DateTime today = DateTime.Today;
        int daysSince = (today-_lastDone).Days;
        Console.WriteLine($"This was last done {daysSince} day(s) ago.");
    }

    public void NextDo()
    {
        DateTime today = DateTime.Today;
        int daysSince = (today-_lastDone).Days;
        int daysUntil = _howOften-daysSince;
        if (daysUntil == 0)
        {
            Console.WriteLine("This needs to be done today.");
        }
        else if (daysUntil < 0)
        {
            Console.WriteLine("This needs to be done today.");
            Console.WriteLine($"This needed to be done {daysUntil * -1} day(s) ago.");
        }
        else{
            Console.WriteLine($"This next needs to be done in {daysUntil} day(s).");
        }
    }

    public string GetTitle()
    {
        return _title;
    }
    public DateTime GetLastDone()
    {
        return _lastDone;
    }
    public double GetWorth()
    {
        return _worth;
    }
    public virtual void DoChore(Person person)
    {
       _lastDone = DateTime.Today;
       _whoDid = person;
       Console.WriteLine($"{_title} was last done on {_lastDone} by {_whoDid.GetName()}.");
       Console.ReadLine();
    }
}