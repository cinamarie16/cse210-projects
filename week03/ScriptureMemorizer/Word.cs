using System.Linq;
using System.Text;

public class Word
{
    private string _text;
    // private bool _isHidden;

    public Word (string text)
    {
        _text = text;
    }

    public string Hide()
    {
        string hiddenWord = _text;
        foreach (char c in _text)
        {
            hiddenWord = hiddenWord.Replace(c, '_');
        }
        _text = hiddenWord;
        return hiddenWord;
    }
    
    public bool IsHidden()
    {
        foreach (char c in _text)
        {
            if (c != '_')
            {
                // _isHidden = false;
                return false;
            }
        }
        return true;
    }
}
