using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SosialMedia.Conficurations;

public class CommentConficurations : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(p => p.Text).HasMaxLength(100);
        builder.Property(p => p.Comments).HasMaxLength(120);
        builder.HasMany(x=>x.Posts).WithMany(x=>x.Comments);
    }
}
