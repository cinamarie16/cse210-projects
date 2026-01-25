using System.Linq;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

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
                _isHidden = false;
                return false;
            }
        }
        return true;
    }
    // public void Show()
    // {
    //     // _shownWord = _text;
    // }
    // public string GetDisplayText()
    // {
    //     string text = $"{_text}";
    //     return text;
    //     // if (_isHidden == true)
    //     // {
    //     //     string text = $"{_hiddenWord}";
    //     //     return text;   
    //     // }
    //     // else
    //     // {
    //     //     string text = $"{_shownWord}";
    //     //     return text;
    //     // }
    // }
}
