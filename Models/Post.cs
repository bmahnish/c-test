// Models/Post.cs
public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; } // Make Title nullable
    public string? Content { get; set; } // Make Content nullable
    public DateTime CreatedAt { get; set; }
}