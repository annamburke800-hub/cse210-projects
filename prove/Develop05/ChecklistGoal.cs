using System;
using System.Collections.Concurrent;

public class ChecklistGoal : Goal
{
    private int _goalAmount;
    private int _timesDone;
    private int _bonusPoints;
    private string _check = " ";


    public ChecklistGoal(string title, string description, int points, int goalAmount, int timesDone, int bonusPoints) : base(title, description, points)
    {
        _goalAmount = goalAmount;
        _timesDone = timesDone;
        _bonusPoints = bonusPoints;
    }

    public override void CheckOff()
    {
        _timesDone += 1;
        if (_timesDone == _goalAmount)
        {
            _check = "X";
        }
    }

    public override int GetPoints()
    {
        if(_timesDone < _goalAmount)
        {
            return _points;
        }
        else if (_timesDone == _goalAmount)
        {
            return _bonusPoints;
        }
        else
        {
            return 0;
        }
    }

    public override void ListGoal()
    {
        Console.WriteLine($"[{_check}] {_title} ({_description}) - Completed {_timesDone}/{_goalAmount}");
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"ChecklistGoal:{_title},{_description},{_points},{_goalAmount},{_timesDone},{_bonusPoints},{_check}";
        return stringrep;
    }
}