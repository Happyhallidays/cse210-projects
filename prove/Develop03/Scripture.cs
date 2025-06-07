using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;

    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(name, chapter, verse);
        _words = ConvertToWords(text);
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(name, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
    }

    public bool HideSomeWords()
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return false;

        var random = new Random();
        int hideCount = Math.Min(3, visibleWords.Count);

        for (int i = 0; i < hideCount; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

        return true;
    }

    public void ShowScripture()
    {
        Console.WriteLine($"{_reference.GetScriptureReference()} {string.Join(" ", _words.Select(w => w.GetDisplayText()))}");
    }

    public string GetScriptureReference()
    {
        return _reference.GetScriptureReference();
    }

    private int NumberOfHiddenWords()
    {
        return _words.Count(w => w.IsHidden());
    }

    private List<Word> ConvertToWords(string text)
    {
        return text.Split(' ').Select(word => new Word(word)).ToList();
    }
}
