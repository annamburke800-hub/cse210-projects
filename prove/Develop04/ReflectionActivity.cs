using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless"];
    private List<string> _questions= [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"];

    public ReflectionActivity(string startMessage, string title, string instructions) : base(startMessage, title, instructions)
    {

    }

    public void Reflection()
    {
        Activity a = new Activity("Welcome to the Reflection Activity", "Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
        Console.Clear();
        int seconds = Introduction(a.GetStartMessage(), a.GetTitle(), a.GetInstructions());
        Animation(10);
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string rprompt = _prompts[index];
        Console.WriteLine(new String('-', 48));
        Console.WriteLine(rprompt);
        Console.WriteLine(new String('-', 48));
        Console.WriteLine("When you have an experience in mind, press enter.");
        Console.ReadLine();

        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(seconds);

        DateTime now = DateTime.Now;
        while (now < endtime)
        {
            Random randomquestion = new Random();
            int indexquestion = randomquestion.Next(_questions.Count);
            string rquestion = _questions[indexquestion];
            Console.WriteLine(rquestion);
            Animation(5);
            now = DateTime.Now;
        }
        Console.WriteLine();
        EndMessage(seconds, a.GetTitle());
        Animation(5);
    }
}