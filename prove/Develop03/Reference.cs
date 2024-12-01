using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // This Constructor is for single verse, ie without endVerse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1; // Indicate single verse
    }

    // I used this Constructor for range of verses, ie for startVerse to endVerse.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Returns Reference for me based of the condition met.
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
