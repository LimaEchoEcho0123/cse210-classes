public class Word
{
    private string _text;
    private bool _hidden = false;


    public Word(string text)
    {
        _text = text;
    }

    public void setword(string text)
    {
        _text = text;
    }

    public void hideword()
    {
        _hidden = true;
    }
    
    public void unhideword()
    {
        _hidden = false;
    }

    public bool ishidden()
    {
        return _hidden;
    }

    public string GetText()
    {
        return $"{_text}";
    }
}