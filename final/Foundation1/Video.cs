class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int LengthSeconds { get; private set; }
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public IEnumerable<Comment> GetComments()
    {
        return comments;
    }
}