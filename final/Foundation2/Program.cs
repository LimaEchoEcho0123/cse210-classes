using System;

class Program
{
    static void Main(string[] args)
    {
       Order order = new("Body Wash", "Leonardo Gear", "1654 E Hamilton Drive - Helper Mountain - Area 51");
    
        int action = -1;
        while (action != 5)
        {

        Console.WriteLine("Enter the number 1 to begin... others to quit");
        
        string number = Console.ReadLine();
        int choice = int.Parse(number);

            if (choice == 1)
            {
                Console.WriteLine(order.WholeOrder());
            }
        }
    }
}