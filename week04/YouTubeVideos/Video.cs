using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int NumberOfComments()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }

    public void DisplayVideos()
    {
        int number = NumberOfComments();
        Console.WriteLine();
        Console.WriteLine($"Title:{_title} - Author:{_author}");
        Console.WriteLine($"Length in Seconds:{_length} - Number of comments:{number}");
        foreach (Comment c in _comments)
        {
            c.DisplayComments();
        }
    }
}