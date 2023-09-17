using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int value = 0;
        while (value != number)
        {
            Console.Write("What is the magic number? ");
            value = int.Parse(Console.ReadLine());
            if (value > number)
            {
            Console.WriteLine("Lower");
            }
            else if (value < number)
            {
            Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You Got it!");
            }
        }
    }
}