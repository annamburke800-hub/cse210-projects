using System;
using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _word;

    private bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
        
    }

    public void DisplayWord()
    {
        if (_word != "." && _word != "," && _word != ";")
        {
            Console.Write($" {_word}");
        }
        else
        {
            Console.Write($"{_word}");
        }
    }

    public bool HideWord()
    {
        if (_isHidden == false)
        {
            if (_word != "." && _word != "," && _word != ";")
            {
                _isHidden = true;
                _word = string.Concat(Enumerable.Repeat("_", _word.Length));
            }
            return true;
        }
        else
        {
            return false;
        }
        
        
    }
}