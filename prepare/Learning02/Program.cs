using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Amazon";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // job1.DisplayDetails();
        // job2.DisplayDetails();

        Resume resume1 = new Resume();
        resume1._name = "Jane Doe";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}