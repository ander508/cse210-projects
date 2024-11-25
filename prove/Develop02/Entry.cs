using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }

    public static Entry FromFileFormat(string line)
    {
        var parts = line.Split("~|~");
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}
