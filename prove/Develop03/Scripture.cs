using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Scripture
{

    Reference _reference;
    List<Word> _WordText = new List<Word>();

    
    public Scripture(Reference reference, string refertext)
    {
        _reference = reference;
        List<string> _WordText = new List<string>(refertext.Split(" "));
        
        // foreach(var words in WordText)
        // {
        //     Word refertextword = new(words);
        //    _WordText.Add(refertextword);
        // }
    }

    public void hiderandomword(int hidenumber)
    {
       _WordText[hidenumber].hideword();
    }

        public int getWords()
    {
        return _WordText.Count();
    }

    public void DisplayScripture()
    {
        
        foreach (Word  in _WordText)
        {
            _WordText.Displ();
        }
      
        
        // foreach (Word word in WordText)
        // {
        //     if (word.ishidden() == true)
        //     {
        //         return $"";
        //     }
        //     else
        //     {
        //         return " ";
        //     }

        // }
  
    }
}
