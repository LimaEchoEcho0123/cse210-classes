using System.Security.Cryptography.X509Certificates;

public class PromptGenerator{
    public List<string> listprompt = new List<string>();
    public string GetRandomPrompt()
    {
        var Random = new Random();
        int index = Random.Next(listprompt.Count);
        return listprompt[index];
    }

    public void addPrompts()
    {
        listprompt.Add("What did you do today?");

        listprompt.Add("What are you thinking about?");

        listprompt.Add("Spiritual experience?");

        listprompt.Add("What are you craving?");

        listprompt.Add("Funniest thing you saw today?");
    }
}