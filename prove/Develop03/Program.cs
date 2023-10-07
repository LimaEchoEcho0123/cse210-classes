using System;
using System.Transactions;

class Program
{   
    static void Main(string[] args)
    {   


        Reference reference = new("Helaman", 12, 15);
        string verseText = "And thus, according to his word the earth goeth back, and it appeareth unto man that the sun standeth still; yea, and behold, this is so; for surely it is the earth that moveth and not the sun.";
        Scripture scripture = new(reference,verseText);


        // ConsoleKeyInfo keyInfo = Console.ReadKey();
        // while(keyInfo.Key != ConsoleKey.Enter)
        //     keyInfo = Console.ReadKey();

        ConsoleKeyInfo Enter = Console.ReadKey();
        while (Enter.Key == ConsoleKey.Enter)
        {
            if (Enter == Console.ReadKey())
            {
                
                Console.WriteLine(reference.EntireText());
                Console.WriteLine(scripture.getWords());
                Console.WriteLine(scripture.DisplayScripture());
                Console.WriteLine("\nPress the enter key to start and continue. Type 'quit' to end the session.");
            }
            
            else 

            {
                break;
            }
        }
    }
}