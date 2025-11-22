using System;

public class Quest
{
    private int _totalPoints = 0;
    private List<Goal> _goals = new List<Goal>();

    public void Menu()
    {
        string menuQ; // stands for menu question
        int sessionEvents = 0;
        do
        {
            Console.Clear();
            // Console.WriteLine(sessionEvents);
            Console.WriteLine($"You have {_totalPoints} points");
            Console.WriteLine("Select an option using the number:\n1. Create Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            menuQ = Console.ReadLine();

            if (menuQ == "1") // create Goal
            {
                Console.Clear();
                Goal newGoal = CreateGoal();
                _goals.Add(newGoal);
            }
            else if (menuQ == "2")// list goals
            {
                Console.Clear();
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.Write($"{i+1}. ");
                    _goals[i].ListGoal();
                }
                Console.ReadLine();
            }
            else if (menuQ == "3")// save goals
            {
                Console.Clear();
                Console.WriteLine("What file will you save to?");
                string filepath = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filepath))
                {
                    outputFile.WriteLine(_totalPoints);
                    for (int i = 0; i < _goals.Count; i++)
                    {
                        outputFile.WriteLine(_goals[i].GetStringRepresentation());
                    }
                }
                Console.WriteLine("Your file has been saved");
                Console.ReadLine();
            }
            else if (menuQ == "4")// load goals
            {
                Console.Clear();
                string filepath;
                do{
                Console.WriteLine("What file are you loading?");
                filepath = Console.ReadLine();
                if (File.Exists(filepath)== false)
                    {
                        Console.WriteLine($"Error: {filepath} does not exist.");
                    }
                } while (File.Exists(filepath) == false);

                _totalPoints = int.Parse(File.ReadLines(filepath).First());

                string[] allLines = System.IO.File.ReadAllLines(filepath);
                string[] skipFirstLine = allLines.Skip(1).ToArray();

                foreach (string line in skipFirstLine)
                {
                    string[] oneLine = line.Split(':',',');
                    if (oneLine[0] == "SimpleGoal")
                    {
                        Goal newGoal = new SimpleGoal(oneLine[1],oneLine[2],int.Parse(oneLine[3]), bool.Parse(oneLine[5]));
                        _goals.Add(newGoal);
                    }
                    else if (oneLine[0] == "EternalGoal")
                    {
                        Goal newGoal = new EternalGoal(oneLine[1],oneLine[2],int.Parse(oneLine[3]));
                        _goals.Add(newGoal);
                    }
                    else if (oneLine[0] == "ChecklistGoal")
                    {
                        Goal newGoal = new ChecklistGoal(oneLine[1],oneLine[2],int.Parse(oneLine[3]),int.Parse(oneLine[4]),int.Parse(oneLine[5]),int.Parse(oneLine[6]));
                        _goals.Add(newGoal);
                    }
                }

                Console.WriteLine("Your file has been loaded");
                Console.ReadLine();
            }
            else if (menuQ == "5")//record event
            {
                Console.Clear();
                int eventQ;
                do{
                Console.WriteLine("Which goal did you accomplish?");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.Write($"{i+1}. ");
                    _goals[i].ListGoal();
                }
                eventQ = int.Parse(Console.ReadLine()); 
                eventQ -= 1;
                } while (eventQ > _goals.Count);
                
                int newPoints = _goals[eventQ].GetPoints();
                _goals[eventQ].CheckOff();
                sessionEvents += 1;
                // Console.WriteLine(sessionEvents);
                if (sessionEvents == 5)
                {
                    Console.WriteLine("You have completed 5 goals in this session!");
                    Console.WriteLine("You get 200 extra points, and 50 additional points for every goal completed after this in this session.");
                    newPoints += 200;
                }
                else if (sessionEvents > 5)
                {
                    newPoints += 50;
                }

                Console.WriteLine($"Congratulations! You have earned {newPoints} points!");
                _totalPoints = _totalPoints + newPoints;
                
                
                Console.ReadLine();

            }

        } while (menuQ != "6");
    }

    public Goal CreateGoal()
    {
        Goal newGoal;
        string goalQ;
        do{
        Console.WriteLine("Which type of goal will you create?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        goalQ = Console.ReadLine(); // stands for goal question
        } while (goalQ != "1" && goalQ != "2" && goalQ != "3");
        Console.WriteLine("What is the title of this goal?");
        string title = Console.ReadLine();
        Console.WriteLine($"Please enter a short description of {title}");
        string description = Console.ReadLine();
        Console.WriteLine($"How many points is {title} worth?");
        int points = int.Parse(Console.ReadLine());
        if (goalQ == "1")
        {
            newGoal = new SimpleGoal(title, description, points, false);

        }
        else if (goalQ == "2")
        {
            newGoal = new EternalGoal(title, description, points);
        }
        else if (goalQ == "3")
        {
            Console.WriteLine("How many times will you accomplish this goal?");
            int goalAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many bonus points will you get when you complete this?");
            int bonusPoints = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(title, description, points, goalAmount, 0, bonusPoints);

        }
        else
        {
            newGoal = CreateGoal();
        }
        return newGoal;
    }
    



}