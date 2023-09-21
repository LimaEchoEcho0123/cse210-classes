public class Resume
{
    public string _name;
    public List<Job> _Job = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job Job in _Job)
        {
            Job.Display();
        }


    }

}