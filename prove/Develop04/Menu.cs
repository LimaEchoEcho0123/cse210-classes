public class Menu
{
    public string _name;
    
    public string _description;

    public int _duration;

    public Menu()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    
    public int Timer()
    {
        Console.WriteLine("How many seconds you want for the activity?");
        string time = Console.ReadLine();
        int _duration = int.Parse(time);
        return _duration;
    }    
    
    public void DisplayStartingMessage()
    {
        string DisplayStartMessage = $"Welcome to {_name} \n{_description}";
        Console.WriteLine($"{DisplayStartMessage}");
        Console.WriteLine("How many seconds you want for the activity?");
        string time = Console.ReadLine();
        int _duration = int.Parse(time);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done");
        
    }
    public void ShowSpinner()
    {
        Console.WriteLine($"Get Ready...");
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }    
    public void ShowCountdown()
    {
        for (int i = 5; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}