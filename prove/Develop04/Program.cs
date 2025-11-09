using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        BreathingActivity a = new BreathingActivity("Welcome to the Breathing Activity", "Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. You will breathe in for 4 seconds, hold for 4 seconds, and breathe out for 8 seconds. Clear your mind and focus on your breathing");
        ReflectionActivity b = new ReflectionActivity("Welcome to the Reflection Activity", "Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
        ListingActivity c = new ListingActivity("Welcome to the Listing Activity", "Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");

        string menuchoice;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the mindfulness program. Please input the number for your activity.\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit");
            menuchoice = Console.ReadLine();
            if (menuchoice == "1")
            {
                a.Breathing();
            }
            else if (menuchoice == "2")
            {
                b.Reflection();
            }
            else if (menuchoice == "3")
            {
                c.Listing();
            }


        } while (menuchoice != "4");
        Console.WriteLine("Thank you for being Mindful. I hope to see you again soon.");


    }
}