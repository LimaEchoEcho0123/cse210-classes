using System;
using System.IO;
using System.IO.Enumeration;
class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();

        PromptGenerator prompt = new PromptGenerator();
        prompt.addPrompts();


        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        int action = -1;
        while (action != 5)
        {

        Console.WriteLine("Welcome to your Journal!");
        Console.WriteLine("How may I assist you??");
        Console.WriteLine("1. Add Entry\n2. Display All Entries\n3. Save to File\n4. Load file.\n5. Quit.");

        
        string number = Console.ReadLine();
        int choice = int.Parse(number);

            if (choice == 1)
            {   
                string actualprompt = prompt.GetRandomPrompt();
                Console.WriteLine(actualprompt);
                string response = Console.ReadLine();

                Entry entry = new Entry()
                {
                    _date = date,
                    _promptText = actualprompt,
                    _entryText = response
                };
                journal.AddEntry(entry);
                entry.Display();

            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                
                string filename = "myfile.txt";
                journal.SaveFile(filename);


            }

            else if (choice == 4)
            {
                string filename = "myfile.txt";
                journal.LoadFile(filename);

            }

            else
            {
                Console.WriteLine("GoodBye!");
                break;
            }
        }
    }
}    