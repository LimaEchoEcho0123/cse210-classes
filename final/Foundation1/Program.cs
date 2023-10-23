using System;

class Program
{
    static void Main(string[] args)
    {
        int action = -1;
        while (action != 5)
        {

        Console.WriteLine("Write the number 1 to begin... other numbers to exit");

        
        string number = Console.ReadLine();
        int choice = int.Parse(number);

            if (choice == 1)
            {  
                Console.Clear();
                Console.WriteLine("Write the title");
                string title = Console.ReadLine();
                Console.WriteLine("Write the author");
                string author = Console.ReadLine();
                Console.WriteLine("Write the length");
                string length1 = Console.ReadLine();
                int length = int.Parse(length1);
                Console.WriteLine("Write the total number of comments");
                string totalcomments1 = Console.ReadLine();
                int totalcomments = int.Parse(totalcomments1);
                Videos videos = new Videos()
                {
                    _title = title,
                    _author = author,
                    _length = length,
                    _totalcomments = totalcomments
                };

                Console.WriteLine("What is the name of the commenter");
                string name = Console.ReadLine();
                Console.WriteLine("Write all of their comments");
                string comment = Console.ReadLine();
                Comments listcomment = new Comments()
                {
                    _name = name,
                    _comments = comment
                };
                Console.Clear();
                listcomment.addText();
                videos.Display();
                Console.WriteLine();
                listcomment.displaycomment();
            }
            else
            {
                break;
            }
        } 
    }
}