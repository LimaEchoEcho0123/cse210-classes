using System.ComponentModel;
using Microsoft.VisualBasic;

public class Reflection : Menu
{
    public List<string> _prompts;

    public List<string> _questions;
 
    static Random indexnumber = new Random();
    int index = indexnumber.Next(1, 3);


    public Reflection()
    
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect ...";
        _duration = 50;
    }
    public void Run()
    {
        Console.WriteLine("Get Ready...");

    }
    public void GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Think about your favorite animal",
            "Think about your favorite food",
            "Think about the scriptures",
            "Think about your hobbies"
            
        };

        // var Random = new Random();
        // int index = Random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);


    }
    public void GetRandomQuestion()
    {
        List<string> questions = new List<string>
        {
            "What kind of color you want your favorite animal to be?",
            "What combination of food fits well with that food?",
            "What scriptures come to mind about Christ?",
            "What is another hobbie that fits well with that hobbie?"
        };
        Console.WriteLine(questions[index]);
        Console.ReadLine();

        
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetRandomPrompt}");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"{GetRandomQuestion}");
    }
}
