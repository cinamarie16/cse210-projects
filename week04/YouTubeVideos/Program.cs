using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Comment c1v1 = new Comment();
        c1v1._commenterName = "name1-1";
        c1v1._commentText = "comment text1-1";
        Comment c2v1 = new Comment();
        c2v1._commenterName = "name2-1";
        c2v1._commentText = "comment text2-1";
        Comment c3v1 = new Comment();
        c3v1._commenterName = "name3-1";
        c3v1._commentText = "comment text3-1";
        Comment c4v1 = new Comment();
        c4v1._commenterName = "name4-1";
        c4v1._commentText = "comment text 4-1";

        Video v1 = new Video();
        v1._title = "title1-1";
        v1._author = "author1-1";
        v1._length = 90;
        v1._comments.Add(c1v1);
        v1._comments.Add(c2v1);
        v1._comments.Add(c3v1);
        v1._comments.Add(c4v1);

        videos.Add(v1);

        Comment c1v2 = new Comment();
        c1v2._commenterName = "name1-2";
        c1v2._commentText = "comment text1-2";
        Comment c2v2 = new Comment();
        c2v2._commenterName = "name2-2";
        c2v2._commentText = "comment text2-2";
        Comment c3v2 = new Comment();
        c3v2._commenterName = "name3-2";
        c3v2._commentText = "comment text3-2";

        Video v2 = new Video();
        v2._title = "title1-2";
        v2._author = "author1-2";
        v2._length = 120;
        v2._comments.Add(c1v2);
        v2._comments.Add(c2v2);
        v2._comments.Add(c3v2);

        videos.Add(v2);

        Comment c1v3 = new Comment();
        c1v3._commenterName = "name1-3";
        c1v3._commentText = "comment text1-3";
        Comment c2v3 = new Comment();
        c2v3._commenterName = "name2-3";
        c2v3._commentText = "comment text2-3";
        Comment c3v3 = new Comment();
        c3v3._commenterName = "name3-3";
        c3v3._commentText = "comment text3-3";

        Video v3 = new Video();
        v3._title = "title1-3";
        v3._author = "author1-3";
        v3._length = 600;
        v3._comments.Add(c1v3);
        v3._comments.Add(c2v3);
        v3._comments.Add(c3v3);

        videos.Add(v3);

        Comment c1v4 = new Comment();
        c1v4._commenterName = "name1-4";
        c1v4._commentText = "comment text1-4";
        Comment c2v4 = new Comment();
        c2v4._commenterName = "name2-4";
        c2v4._commentText = "comment text2-4";
        Comment c3v4 = new Comment();
        c3v4._commenterName = "name3-4";
        c3v4._commentText = "comment text3-4";
        Comment c4v4 = new Comment();
        c4v4._commenterName = "name4-4";
        c4v4._commentText = "comment text4-4";

        Video v4 = new Video();
        v4._title = "title1-4";
        v4._author = "author1-4";
        v4._length = 20;
        v4._comments.Add(c1v4);
        v4._comments.Add(c2v4);
        v4._comments.Add(c3v4);

        videos.Add(v4);

        foreach (Video v in videos)
        {
            v.DisplayVideos();
        }
    }
}