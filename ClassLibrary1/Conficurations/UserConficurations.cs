using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SosialMedia.Conficurations;

public class UserConficurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder .HasKey(u=>u.Id);
        builder.HasMany(u => u.Posts)
             .WithOne(p => p.User)
             .HasForeignKey(p => p.UserId);
    }
}
