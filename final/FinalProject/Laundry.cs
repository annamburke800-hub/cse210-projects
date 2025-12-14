using System;

public class Laundry : Chore
{
    public Laundry(string title, string description, int howOften, DateTime lastDone, double worth, string whoDid) : base(title, description, howOften, lastDone, worth, whoDid){}

    //you need to do both parts to complete the chore

    public override void DoChore(Person person)
    {
        Console.WriteLine("Have you put the clothes in both the laundry machine AND the dryer?\n1. Yes\n2. No");
        int menuq = int.Parse(Console.ReadLine());
        if (menuq == 1)
        {
            base.DoChore(person);
        }
        else
        {
            Console.WriteLine("Make sure to do both parts before logging!");
            Console.ReadLine();
        }
    }
}