using System;

public class Vacuum : Chore
{
    public Vacuum(string title, string description, int howOften, DateTime lastDone, double worth, Person whoDid) : base(title, description, howOften, lastDone, worth, whoDid){}

    // if it's past 10:00pm it wont let you do it 'cause its loud

    public override void DoChore()
    {
        base.DoChore();
    }
}