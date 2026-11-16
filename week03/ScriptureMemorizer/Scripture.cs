using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string item in wordArray)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new Random();
        int count = 0;

        while (count < numberToHide && visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            count++;
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {text.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}