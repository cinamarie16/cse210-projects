using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<string> _words = new List<string>();
    private string _verseText;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<string>();
        string[] wordsArray = text.Split(new char[] {' '});

        foreach (string w in wordsArray)
        {
            _words.Add(new string(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int leftToHide = numberToHide;
        do
        {
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, _words.Count);

            string randomWord = _words[randomIndex];
            Word w1 = new Word(randomWord);

            bool w1Hidden = w1.IsHidden();
            if (w1Hidden == false)
            {
                string hiddenWord = w1.Hide();
                _words[randomIndex] = hiddenWord;
                leftToHide = leftToHide - 1;
            }
        } while (leftToHide > 0);
    }
    
    public string GetDisplayText()
    {
        _verseText = string.Join(' ', _words);
        string text = $"{_reference.GetDisplayText()} {_verseText}";
        return text;
    }
    
    public bool IsCompletelyHidden()
    {
        foreach (string w in _words)
        {
            Word w1 = new Word(w);
            bool hidden = w1.IsHidden();
            if (hidden != true)
            {
                return false;
            }
        }
        return true;
    }

    public int NumberOfWords()
    {
        int numberOfWords = _words.Count;
        return numberOfWords;
    }
}