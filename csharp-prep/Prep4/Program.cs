using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter numbers... 0 to finish: ");
            
            string Enterednums = Console.ReadLine();
            number = int.Parse(Enterednums);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int total = 0;
        foreach (int Number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max = numbers[0];

        foreach (int Number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}