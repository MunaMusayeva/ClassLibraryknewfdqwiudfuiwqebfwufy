using System.Security.Principal;

namespace ClassLibrary2.Abstract;

public class Base
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }

}
