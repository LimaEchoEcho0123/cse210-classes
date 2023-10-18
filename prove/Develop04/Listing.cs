public class Listing : Menu
{
    public int _count;

    public List<string> _prompts;
    static Random indexnumber = new Random();
    int index = indexnumber.Next(1,5);

    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you List ...";
        _duration = 50;
    }
    public void Run()
    {
        Console.WriteLine("Get Ready...");
        GetRandomPrompt2();
        Console.WriteLine($"{GetRandomPrompt2}");
    }
    public void GetRandomPrompt2()
    {
        List<string> prompts2 = new List<string>
        {
            "Write a list of foods",
            "Write a list of songs",
            "Write a list of games",
            "Write a list of thoughts",
        };
        Console.WriteLine(prompts2[index]);
    }
    public void writelist()
    {
        Console.WriteLine("You may begin");
        List<string> GetlistfromUser = new List<string>();
        string writer = Console.ReadLine();
        GetlistfromUser.Add(writer);
        var numberofline = GetlistfromUser.Count;
        foreach (string line in GetlistfromUser)
        {
            Console.WriteLine($"{line}");
        }
        Console.WriteLine($"You have written {numberofline}");
        
            

        

    }
}