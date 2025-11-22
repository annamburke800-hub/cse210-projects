using System;

public class Quest
{
    private int _totalPoints = 0;
    private List<Goal> _goals = new List<Goal>();

    public void Menu()
    {
        string menuq; // stands for menu question
        int sessionevents = 0;
        do
        {
            Console.Clear();
            // Console.WriteLine(sessionevents);
            Console.WriteLine($"You have {_totalPoints} points");
            Console.WriteLine("Select an option using the number:\n1. Create Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            menuq = Console.ReadLine();

            if (menuq == "1") // create Goal
            {
                Console.Clear();
                Goal newgoal = CreateGoal();
                _goals.Add(newgoal);
            }
            else if (menuq == "2")// list goals
            {
                Console.Clear();
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.Write($"{i+1}. ");
                    _goals[i].ListGoal();
                }
                Console.ReadLine();
            }
            else if (menuq == "3")// save goals
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
            else if (menuq == "4")// load goals
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

                string[] alllines = System.IO.File.ReadAllLines(filepath);
                string[] skipfirstline = alllines.Skip(1).ToArray();

                foreach (string line in skipfirstline)
                {
                    string[] oneline = line.Split(':',',');
                    if (oneline[0] == "SimpleGoal")
                    {
                        Goal newgoal = new SimpleGoal(oneline[1],oneline[2],int.Parse(oneline[3]), bool.Parse(oneline[5]));
                        _goals.Add(newgoal);
                    }
                    else if (oneline[0] == "EternalGoal")
                    {
                        Goal newgoal = new EternalGoal(oneline[1],oneline[2],int.Parse(oneline[3]));
                        _goals.Add(newgoal);
                    }
                    else if (oneline[0] == "ChecklistGoal")
                    {
                        Goal newgoal = new ChecklistGoal(oneline[1],oneline[2],int.Parse(oneline[3]),int.Parse(oneline[4]),int.Parse(oneline[5]),int.Parse(oneline[6]));
                        _goals.Add(newgoal);
                    }
                }

                Console.WriteLine("Your file has been loaded");
                Console.ReadLine();
            }
            else if (menuq == "5")//record event
            {
                Console.Clear();
                int eventq;
                do{
                Console.WriteLine("Which goal did you accomplish?");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.Write($"{i+1}. ");
                    _goals[i].ListGoal();
                }
                eventq = int.Parse(Console.ReadLine()); 
                eventq -= 1;
                } while (eventq > _goals.Count);
                
                int newpoints = _goals[eventq].GetPoints();
                _goals[eventq].CheckOff();
                sessionevents += 1;
                // Console.WriteLine(sessionevents);
                if (sessionevents == 5)
                {
                    Console.WriteLine("You have completed 5 goals in this session!");
                    Console.WriteLine("You get 200 extra points, and 50 additional points for every goal completed after this in this session.");
                    newpoints += 200;
                }
                else if (sessionevents > 5)
                {
                    newpoints += 50;
                }

                Console.WriteLine($"Congratulations! You have earned {newpoints} points!");
                _totalPoints = _totalPoints + newpoints;
                
                
                Console.ReadLine();

            }

        } while (menuq != "6");
    }

    public Goal CreateGoal()
    {
        Goal newgoal;
        string goalq;
        do{
        Console.WriteLine("Which type of goal will you create?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        goalq = Console.ReadLine(); // stands for goal question
        } while (goalq != "1" && goalq != "2" && goalq != "3");
        Console.WriteLine("What is the title of this goal?");
        string title = Console.ReadLine();
        Console.WriteLine($"Please enter a short description of {title}");
        string description = Console.ReadLine();
        Console.WriteLine($"How many points is {title} worth?");
        int points = int.Parse(Console.ReadLine());
        if (goalq == "1")
        {
            newgoal = new SimpleGoal(title, description, points, false);

        }
        else if (goalq == "2")
        {
            newgoal = new EternalGoal(title, description, points);
        }
        else if (goalq == "3")
        {
            Console.WriteLine("How many times will you accomplish this goal?");
            int goalamount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many bonus points will you get when you complete this?");
            int bonuspoints = int.Parse(Console.ReadLine());
            newgoal = new ChecklistGoal(title, description, points, goalamount, 0, bonuspoints);

        }
        else
        {
            newgoal = CreateGoal();
        }
        return newgoal;
    }
    



}