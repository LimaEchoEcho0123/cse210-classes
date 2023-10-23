public class Videos
{
    public string _title;
    public string _author;
    public int _length;
    public int _totalcomments;

    public void Display()
    {
        Console.WriteLine($"Title: {_title}, \nAuthor: {_author}, \nVideo Length: {_length}, \nTotal Comments: {_totalcomments}");
        
    }
}
