public class Comments
{
    public List<string> comments = new List<string>();
    public string _name;
    public string _comments;
    public void addText()
    {
        string Text = $"Name of commenter:{_name}, \nAll of their comments:{_comments}";
        comments.Add($"{Text}");
        
    }
    public void displaycomment()
    {
        foreach(var com in comments)
        Console.WriteLine(com);
    }
}

