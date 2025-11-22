using System;

public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base(title, description, points)
    {

    }

    public override void CheckOff()
    {
        
    }

    public override void ListGoal()
    {
        Console.WriteLine($"[ ] {_title} ({_description})");
    }
    public override string GetStringRepresentation()
    {
        string stringrep = $"EternalGoal:{_title},{_description},{_points}";
        return stringrep;
    }
}