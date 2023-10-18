using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        Console.Clear();
        Console.WriteLine($"Menu Options: \n 1. Start Breathing Activity \n 2. Start Reflecting Activity \n 3. Start Listing Activity \n 4. Quit");
        Console.WriteLine($"Select a choice from the menu: ");
        string select = Console.ReadLine();
        int start = int.Parse(select);
        while (start != 4)
        {

            if (start == 1)
            {   
                breathing.DisplayStartingMessage();
                breathing.ShowSpinner();
                for (int i = 0; i < 4; i++)
                {
                    breathing.Run();
                    breathing.ShowCountdown();
                    breathing.Run2();
                    breathing.ShowCountdown();
                }
                breathing.DisplayEndingMessage();
                break;
            }

            else if (start == 2)
            {
                reflection.DisplayStartingMessage();
                reflection.ShowSpinner();
                reflection.GetRandomPrompt();
                reflection.GetRandomQuestion();
                reflection.DisplayEndingMessage();
                break;
            }

            else if (start == 3)
            {
                listing.DisplayStartingMessage();
                listing.ShowSpinner();
                listing.GetRandomPrompt2();
                listing.writelist();
                break;
            }

            else
            {
                menu.DisplayEndingMessage();
                break;
            }

        }
    }
}