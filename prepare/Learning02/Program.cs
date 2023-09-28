using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._company = "Microsoft";
        Job1._startYear = 2019;
        Job1._endyear = 2022;

        Job Job2 = new Job();
        Job2._jobTitle = "Manager";
        Job2._company = "Apple";
        Job2._startYear = 2022;
        Job2._endyear = 2023;

        Resume myResume1 = new Resume();
        myResume1._name = "Allison Rose";

        myResume1._Job.Add(Job1);
        myResume1._Job.Add(Job2);

        myResume1.Display();




         


    }
}


