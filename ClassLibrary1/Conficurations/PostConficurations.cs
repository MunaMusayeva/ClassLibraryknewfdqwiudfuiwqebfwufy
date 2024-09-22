using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SosialMedia;

public class PostConficurations : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.Property(p => p.Text).IsRequired().HasMaxLength(100);
        builder.Property(p=>p.LikeCount).HasDefaultValue(0);
        builder.HasOne(p => p.User ).WithMany(p=>p.Posts).HasForeignKey(p=>p.UserId);
        builder.HasMany(p => p.Comments).WithMany(p => p.Posts);
    }
}
