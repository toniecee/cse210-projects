using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood; // Creative addition: tracks the user's mood

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Entry: {_entryText}");
        // Extra creative metric: word count
        int wordCount = _entryText.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"[Word Count: {wordCount} words]\n");
    }
}