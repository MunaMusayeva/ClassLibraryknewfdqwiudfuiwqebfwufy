using ClassLibrary2.Abstract;

namespace ClassLibrary2.Concrate;

public class UserDetails:Base
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public Roles Role { get; set; }
    public User User { get; set; }
    
}
