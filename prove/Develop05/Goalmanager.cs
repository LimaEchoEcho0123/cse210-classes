public class Goalmanager 
{

    public List<Goal> _goals = new List<Goal>();

    public int _score = 0;




    public void SetterScore(int score)
    {
        _score += score;
    }

    public List<Goal> GetList()
    {
        return _goals;
    }


    public int GetScore()
    {
        return _score;
    }

    public void SetterList(Goal goal)
    {
        _goals.Add(goal);
    }

    // }

    // Menu Interface...

    public void setpoints()
    {
        Console.WriteLine($"You have {GetScore()} points.");
    }
    
    public void CreateGoal()
    {
        int number = 1;
        while (number != 0)
        {
            Console.WriteLine("There are three options...\nChoose one...\n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
            string option = Console.ReadLine();
            int goalmaker = int.Parse(option);
            if (goalmaker == 1)
            {
                // Simple Goal
                Console.WriteLine("What is the name of the goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?");
                string description = Console.ReadLine();
                Console.WriteLine("How many points do you want for this goal?");
                string points = Console.ReadLine();

                SimpleGoal simplegoal = new SimpleGoal(name, description, points);
                SetterList(simplegoal);
                break;
            } 
            else if (goalmaker == 2)
            {
                // Eternal Goal
                Console.WriteLine("What is the name of the goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?");
                string description = Console.ReadLine();
                Console.WriteLine("How many points do you want for this goal?");
                string points = Console.ReadLine();
                EternalGoal eternalgoal = new EternalGoal(name, description, points);
                SetterList(eternalgoal);                
                break;               
            } 
            else if (goalmaker == 3)
            {
                // CheckList Goal
                Console.WriteLine("What is the name of the goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?");
                string description = Console.ReadLine();
                Console.WriteLine("How many points do you want for this goal?");
                string points = Console.ReadLine();
                Console.WriteLine("Bonus points for completing your goal?");
                int bonus = int.Parse(Console.ReadLine());
                Console.WriteLine("How many series are there to complete this goal?");
                int target = int.Parse(Console.ReadLine());
                ChecklistGoal checklistgoal = new ChecklistGoal(name, description, points, bonus, target);
                SetterList(checklistgoal);
                break;
            } 
        }    
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal}");
        }
    }

    public void SaveGoals(string savedfile)
    {
        string filename = savedfile;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(GetScore());
            foreach (Goal goal in _goals)
            {
                
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals(string getfile)
    {
        string filename = getfile;
        string[] lines = System.IO.File.ReadAllLines(filename);
        string [] lines1 = lines.Skip(1).ToArray();

        foreach (string line in lines1)
        {
            string[] parts = line.Split(",");
            string part0 = parts[0];
            string part1 = parts[1];
            string part2 = parts[2];
            string part3 = parts[3];
            string part4 = parts[4];

            Console.WriteLine($"{part0}, {part1}, {part2}, {part3}, {part4}");
        }
    }

    public void RecordEvent()
    {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetStringDetail()}");
            Console.WriteLine("Which goals are completed?");
            int done = int.Parse(Console.ReadLine()) -1;
            if (done == _goals.Count)
            {
            }

        }

    
    }
}