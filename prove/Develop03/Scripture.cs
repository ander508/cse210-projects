using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference; // I used Reference data type here
    private List<Word> _words;   //  I used Word data type here for the List.

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            Word word = _words[random.Next(_words.Count)];
            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
