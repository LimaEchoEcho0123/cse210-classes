public class Event
{
    public string _Title;
    public string _Description;
    public string _Date;
    public string _Time;
    public string _Address;

    public Event()
    {
        _Title = "";
        _Description = "";
        _Date = "";
        _Time = "";
        _Address = "";

    }

    public void EventDisplay()
    {
        Console.Write("What is the name of the Event?");
        string _Title = Console.ReadLine();
        Console.Write("What is the Description of the Event?");
        string _Description = Console.ReadLine();
        Console.Write("What is the Date of the Event?");
        string _Date = Console.ReadLine();
        Console.Write("What is the Time of the Event?");
        string _Time = Console.ReadLine();
        Console.Write("What is the Address of the Event?");
        string _Address = Console.ReadLine(); 

        Console.WriteLine($"{_Title}, {_Description},{_Date},{_Time},{_Address}");
    }
}