using System;

public class Reference
{
    private string _chapter;
    private string _book;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = "";
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = $"-{endVerse}";
    }
    
    public string CreateReference()
    {
        string Reference = $"{_book} {_chapter}:{_startVerse}{_endVerse}";
        return Reference;
    }
    
}