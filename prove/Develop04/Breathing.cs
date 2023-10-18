using System.Globalization;

public class Breathing : Menu
{
    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will help you Breath ...";
        _duration = 10;
    }
    public void Run()
    {
        Console.WriteLine($"Breathe in... ");
    }
    public void Run2()
    {
        Console.WriteLine($"Breathe out... ");
    }
}