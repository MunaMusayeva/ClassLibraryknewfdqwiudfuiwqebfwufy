using ClassLibrary2.Abstract;

namespace ClassLibrary2.Concrate;

public class Comment:Base
{
    public string Text { get; set; }
    public int LikeCount { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<Post> Posts { get; set; }
}
