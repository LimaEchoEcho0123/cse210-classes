public class Reference
{
    private string _bookname;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    public Reference(string bookname, int chapter, int startverse)
    {
        _bookname = bookname;
        _chapter = chapter;
        _startverse = startverse;
    }

    public Reference(string bookname, int chapter, int startverse, int endverse)
    {
        _bookname = bookname;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }


    public string EntireText()
    {
        string EntireText = $"{_bookname} {_chapter}:{_startverse}-{_endverse}";
        return EntireText;
    }

}