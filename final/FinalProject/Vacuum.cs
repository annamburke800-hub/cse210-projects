using System;

public class Vacuum : Chore
{
    public Vacuum(string title, string description, int howOften, DateTime lastDone, double worth, string whoDid) : base(title, description, howOften, lastDone, worth, whoDid){}

    // if it's past 10:00pm it wont let you do it 'cause its loud

    public override void DoChore(Person person)
    {
        DateTime currentTime = DateTime.Now;
        if (currentTime.Hour >= 22 || currentTime.Hour <= 7)
        {
            Console.WriteLine("It's late! Vacuuming now will wake people up. Best to wait until morning.");
            Console.ReadLine();
        }
        else
        {
            base.DoChore(person);
        }
    }
}