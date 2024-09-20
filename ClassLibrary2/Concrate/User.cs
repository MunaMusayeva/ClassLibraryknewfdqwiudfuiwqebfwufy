namespace ClassLibrary2.Concrate;

public class User
{
    public int Id { get; set; }
    public UserDetails UserDetails { get; set; }
    public int UserDetailsId { get; set; }
    public ICollection<Post> Posts { get; set; }
    public ICollection<Comment> Comments { get; set; }
}
