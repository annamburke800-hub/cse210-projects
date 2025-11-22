using System;

public class SimpleGoal : Goal
{

    private string _check = " ";
    private bool _isChecked;
    

    public SimpleGoal(string title, string description, int points, bool isChecked) : base(title, description, points)
    {
        _isChecked = isChecked;
        if (_isChecked == true)
        {
            _check = "X";
        }
    }

    public override void CheckOff()
    {
        if (_isChecked == false)
        {
            _check = "X";
        }

        _isChecked = true;
    }

    public override int GetPoints()
    {
        if(_isChecked == false)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override void ListGoal()
    {
        Console.WriteLine($"[{_check}] {_title} ({_description})");
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"SimpleGoal:{_title},{_description},{_points},{_check},{_isChecked}";
        return stringrep;
    }
}