using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine(); 
        int percentage = int.Parse(percent);

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }
        Console.WriteLine($"You got a {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("You've passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}