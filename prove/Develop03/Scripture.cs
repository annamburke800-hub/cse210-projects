using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Scripture
{
    private Reference _reference;

    private List<Word> _text = new List<Word>();

    public void CreateScripText(string text)
    {
        string[] textwords = text.Split(' ');
        foreach (string textword in textwords)
        {
            Word word1 = new Word(textword);
            _text.Add(word1);
            
        }
    }

    public void DisplayScripture()
    {
        string refstring = _reference.CreateReference();
        Console.Write(refstring);
        foreach (Word word in _text)
        {
            word.DisplayWord();
        }
    }

    public Word RandomizeWords()
    {
        Random random = new Random();
        int index = random.Next(_text.Count());
        Word word = _text[index];
        return word;
    }

    public void MemorizeScripture(Reference reference)
    {
        string qyorn;
        do
        {
            Console.Clear();
            _reference = reference;
            DisplayScripture();
            Console.WriteLine(" ");
            Console.WriteLine("\nTo continue, press enter. To quit, type 'quit'");
            qyorn = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                bool hword;
                do
                {
                    Word rword = RandomizeWords();

                    hword = rword.HideWord();
                } while (hword == false);
                
            }
        } while (qyorn.ToLower() != "quit");

    }
}