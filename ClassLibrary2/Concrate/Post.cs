using ClassLibrary2.Abstract;

namespace ClassLibrary2.Concrate;

public class Post:Base
{
    public Comment Comment { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<Comment> Comments { get; set; }


}
