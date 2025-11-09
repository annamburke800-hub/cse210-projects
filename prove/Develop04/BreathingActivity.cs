using System;

public class BreathingActivity : Activity
{


    public BreathingActivity(string startMessage, string title, string instructions) : base(startMessage, title, instructions)
    {
    }
    
    public void Breathing()
    {
        Activity a = new Activity("Welcome to the Breathing Activity", "Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. You will breathe in for 4 seconds, hold for 4 seconds, and breathe out for 8 seconds. Clear your mind and focus on your breathing");
        Console.Clear();
        int seconds = Introduction(a.GetStartMessage(), a.GetTitle(), a.GetInstructions());
        Animation(12);
        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(seconds);
        

        DateTime now = DateTime.Now;
        while (now < endtime)
        {
            Console.Write("\n\nBreathe in");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Write("\nHold");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Write("\nBreathe out");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            now = DateTime.Now;
        }
        Console.WriteLine();
        EndMessage(seconds, a.GetTitle());
        Animation(5);
    }
}