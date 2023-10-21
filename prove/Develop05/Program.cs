using System;

class Program
{
    static void Main(string[] args)
    {
        Goalmanager goalmanager = new Goalmanager();
        int number = -1;
        while (number != 0)
        {
            goalmanager.setpoints();
            Console.WriteLine("Menu Options: \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.WriteLine("What do you want to do?");
            string select = Console.ReadLine();
            int start = int.Parse(select);
            if (start == 1)
            {
                Console.Clear();
                goalmanager.CreateGoal();
                
            }
            else if (start == 2)
            {
                Console.Clear();
                goalmanager.ListGoalDetails();
                
            }
            else if (start == 3)
            {
                Console.Clear();
                Console.WriteLine("Name a file to save under?");
                string savedfile = Console.ReadLine();
                goalmanager.SaveGoals(savedfile);
                
            }
            else if (start == 4)
            {
                Console.Clear();
                Console.WriteLine("Name a file you want to get?");
                string getfile = Console.ReadLine();
                goalmanager.LoadGoals(getfile);
                
            }
            else if (start == 5)
            {
                Console.Clear();
                goalmanager.RecordEvent();
            
            }
            else
            {
                break;
            }
        }
    }
}