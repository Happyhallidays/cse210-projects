class Program
{
    static void Main()
    {
        var videos = new List<Video>();

        Video v1 = new Video("Intro to C#", "Alice", 600);
        v1.AddComment(new Comment("John", "Great tutorial!"));
        v1.AddComment(new Comment("Emma", "Thanks for sharing."));
        v1.AddComment(new Comment("Mike", "Very helpful."));
        videos.Add(v1);

        Video v2 = new Video("Advanced OOP Concepts", "Bob", 900);
        v2.AddComment(new Comment("Sara", "This helped me understand inheritance."));
        v2.AddComment(new Comment("Dave", "Nice explanation."));
        videos.Add(v2);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthSeconds}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}