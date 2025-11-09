using System;
using System.Reflection;

public class Activity
{
    private string _startMessage;
    // private string _endMessage;
    private int _seconds;
    private string _title;
    private string _instructions;

    public Activity(string startmessage, string title, string instructions)
    {
        _startMessage = startmessage;
        // _endMessage = endmessage;
        _title = title;
        _instructions = instructions;
    }

    public string GetStartMessage()
    {
        return _startMessage;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetInstructions()
    {
        return _instructions;
    }
    // public string GetEndMessage()
    // {
    //     // return _endMessage;
    // }

    public int AskDuration()
    {
        Console.WriteLine("How long in seconds would you like this activity to go on?");
        int duration = int.Parse(Console.ReadLine());
        return duration;
    }

    public void Animation(int seconds)
    {
        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(seconds);

        DateTime now = DateTime.Now;
        while (now < endtime)
        {
            Console.Write(".");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("O");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(400);
            Console.Write("\b \b");
            now = DateTime.Now;
        }
    }

    public int Introduction(string _startMessage, string _title, string _instructions)
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_startMessage}");
        _seconds = AskDuration();
        Console.WriteLine($"{_instructions}");
        return _seconds;
    }

    public void EndMessage(int _seconds, string _title)
    {
        Console.WriteLine($"You completed {_seconds} seconds of the {_title}");
    }


}