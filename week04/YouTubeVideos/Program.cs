using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Soil Health and Crop Rotation Basics";
        video1._author = "AgriLearn Channel";
        video1._lengthSeconds = 645;

        Comment comment1 = new Comment();
        comment1._commenterName = "Amina Bello";
        comment1._text = "Very practical tips for small plots.";
        video1.AddComment(comment1);

        Comment comment2 = new Comment();
        comment2._commenterName = "David Okafor";
        comment2._text = "The cover crop breakdown was super clear.";
        video1.AddComment(comment2);

        Comment comment3 = new Comment();
        comment3._commenterName = "Grace Mensah";
        comment3._text = "Tried this last season and saw great results.";
        video1.AddComment(comment3);

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Intro to C# Classes and Encapsulation";
        video2._author = "CodeCraft Academy";
        video2._lengthSeconds = 920;

        Comment comment4 = new Comment();
        comment4._commenterName = "Lucas Reed";
        comment4._text = "Explained member variables without overcomplicating it.";
        video2.AddComment(comment4);

        Comment comment5 = new Comment();
        comment5._commenterName = "Priya Nair";
        comment5._text = "Helpful walkthrough of list composition.";
        video2.AddComment(comment5);

        Comment comment6 = new Comment();
        comment6._commenterName = "Samuel Ade";
        comment6._text = "Subscribing for more object-oriented examples.";
        video2.AddComment(comment6);

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Post-Harvest Storage Best Practices";
        video3._author = "HarvestWise";
        video3._lengthSeconds = 510;

        Comment comment7 = new Comment();
        comment7._commenterName = "Fatima Musa";
        comment7._text = "Moisture control advice saved us a lot of loss.";
        video3.AddComment(comment7);

        Comment comment8 = new Comment();
        comment8._commenterName = "Kevin Park";
        comment8._text = "Clean visual comparison of storage containers.";
        video3.AddComment(comment8);

        Comment comment9 = new Comment();
        comment9._commenterName = "Ngozi Eze";
        comment9._text = "Sharing this with our cooperative group.";
        video3.AddComment(comment9);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayDetails();
        }
    }
}