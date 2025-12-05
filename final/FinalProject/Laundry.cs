using System;

public class Laundry : Chore
{
    public Laundry(string title, string description, int howOften, DateTime lastDone, double worth, Person whoDid) : base(title, description, howOften, lastDone, worth, whoDid){}

    //you need to do both parts to complete the chore

    public override void DoChore()
    {
        base.DoChore();
    }
}