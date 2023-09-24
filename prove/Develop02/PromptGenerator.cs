using System.Security.Cryptography.X509Certificates;

public class PromptGenerator{
    public List<Entry> entries;
    public string GetRandomPrompt()
    {
        var Random = new Random();
        int index = Random.Next(entries.Count);
        string str = index.ToString();
        string Prompt = str;
        return Prompt;
    }
}