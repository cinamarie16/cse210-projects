using System;

public class Comment
{
    public string _commenterName;
    public string _commentText;

    public void DisplayComments()
    {
        Console.WriteLine($"{_commenterName} - {_commentText}");
    }
}