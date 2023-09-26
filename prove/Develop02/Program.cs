using System;
class Program
{
    static void Main(string[] args)
    {
        int action = -1;
        while (action != 5)
        {
        string _ranprompt = "";
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        string _date = date.ToString();
        List<Journal> entries = new List<Journal>();
        entries.Add(new Journal());
        entries[0]._promptText = "What did you do today?";
        entries.Add(new Journal());
        entries[1]._promptText = "What are you thinking about?";
        entries.Add(new Journal());
        entries[2]._promptText = "Spiritual experience?";
        entries.Add(new Journal());
        entries[3]._promptText = "What are you craving?";
        entries.Add(new Journal());
        entries[4]._promptText = "Funniest thing you saw today?";
        PromptGenerator prompt = new PromptGenerator();
        // prompt._ranprompt = PromptGenerator.GetRandomPrompt();
        Entry Date = new Entry();
        Date._date = DateTime.Now.ToString();
        Console.WriteLine("Welcome to your Journal!");
        Console.WriteLine("How may I assist you??");
        Console.WriteLine("1. Add Entry\n2. Display All Entries\n3. Save to File\n4. Load file.\n5. Quit.");
        string number = Console.ReadLine();
        int choice = int.Parse(number);

            if (choice == 1)
            {
                Console.WriteLine($"{entries[0]._promptText}, {_date}");
                

            

            }

            else if (choice == 2)
            {


            }

            else if (choice == 2)
            {

            }

            else if (choice == 3)
            {

            }

            else if (choice == 4)
            {

            }

            else
            {
            }
        }
    }
}    
// Journal journal = new Journal();        
// PromptGenerator promptGenerator = new PromptGenerator();

// Console.WriteLine("Welcome to your Journal!");
// Console.WriteLine("How may I assist you??");
// Console.WriteLine("1. Add Entry\n2. Display All Entries\n3. Save to File\n4. Load file.\n5. Quit.");

// string number = Console.ReadLine();
// int action = int.Parse(number);