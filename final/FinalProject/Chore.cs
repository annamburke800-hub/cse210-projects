using System;

public  class Chore
{
    protected string _title;
    protected string _description;
    private int _howOften;
    private DateTime _lastDone;
    private double _worth;
    protected string _whoDid;

    public Chore(string title, string description, int howOften, DateTime lastDone, double worth, string whoDid)
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
        DateTime today = DateTime.Today;
        if ((today-_lastDone).Days < 9999)
        {
            Console.WriteLine($"Last done by {_whoDid}");
        }
        
    }

    public void LastDone()
    {
        DateTime today = DateTime.Today;
        int daysSince = (today-_lastDone).Days;
        if (daysSince < -99999)
        {
            Console.WriteLine($"This was last done {daysSince} day(s) ago.");
        }
        
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
        else if (daysUntil < -99999)
        {
            Console.WriteLine("This chore has not been done yet");
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
    public string GetWhoDid()
    {
        return _whoDid;
    }
    
    public virtual void DoChore(Person whoDid)
    {
       _lastDone = DateTime.Today;
       _whoDid = whoDid.GetName();
       Console.WriteLine($"{_title} was last done on {_lastDone.ToString("yyyy-MM-dd")} by {_whoDid}.");
       Console.ReadLine();
    }

    public virtual string GetStringRepresentation()
    {
        string details = $"{_title}|{_description}|{_howOften}|{_lastDone}|{_worth}|{_whoDid}";
        return details;
    }
}