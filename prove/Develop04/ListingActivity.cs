using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];

    public ListingActivity(string startMessage, string title, string instructions) : base(startMessage, title, instructions)
    {

    }
    
    public void Listing()
    {
        Activity a = new Activity("Welcome to the Listing Activity", "Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
        Console.Clear();
        int seconds = Introduction(a.GetStartMessage(), a.GetTitle(), a.GetInstructions());
        Animation(7);
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string rprompt = _prompts[index];
        Console.WriteLine(new String('-', 48));
        Console.WriteLine(rprompt);
        Console.WriteLine(new String('-', 48));
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
        }
        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(seconds);

        DateTime now = DateTime.Now;
        int j = 0;
        Console.WriteLine();
        while (now < endtime)
        {
            Console.ReadLine();
            now = DateTime.Now;
            j++;
        }
        Console.WriteLine($"You listed {j} things");
        Console.WriteLine();
        EndMessage(seconds, a.GetTitle());
        Animation(5);
    }
}