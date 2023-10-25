using System;

class Program
{
     
    static void Main(string[] args)
    {
        Event event1 = new Event();
        
        int action = -1;
        while (action != 5)
        {
            Console.WriteLine("Write the number 1 to begin... other numbers to exit");
            event1.EventDisplay();

        }
    }
}