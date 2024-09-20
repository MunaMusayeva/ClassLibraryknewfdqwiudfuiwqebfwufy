using ClassLibrary2.Abstract;

namespace ClassLibrary2.Concrate;

public class Comment:Base
{
    public Comment Comments { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public ICollection<Post> Posts { get; set; }
}
