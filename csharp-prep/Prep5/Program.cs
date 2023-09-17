using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squarednumber = SquareNumber(number);

        DisplayResult(name, squarednumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string yourname = Console.ReadLine();

        return yourname;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnumber = int.Parse(Console.ReadLine());

        return favnumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}