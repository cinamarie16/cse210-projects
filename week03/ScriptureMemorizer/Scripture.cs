using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class Scripture
{
    private Reference _reference;
    // private List<Word> _words = new List<Word>();
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
            int maxIndex = _words.Count;
            // getRandom number within max index range
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(1, maxIndex);
            int listIndex = randomIndex - 1;

            // get random word
            string randomWord = _words[listIndex];
            Word w1 = new Word(randomWord);

            // check if word at index isHidden
            bool w1Hidden = w1.IsHidden();
            if (w1Hidden == false)
            {
                // hide word at the random index
                string hiddenWord = w1.Hide();
                _words[listIndex] = hiddenWord;
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
        // check if whole scripture is hidden
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

}