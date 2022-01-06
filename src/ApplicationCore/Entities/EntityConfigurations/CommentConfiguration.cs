using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.EntityConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.UserId).IsRequired();

            builder.HasOne(x => x.News).WithMany(x => x.Comments).HasForeignKey(x => x.NewsId).IsRequired();

            builder.Property(x => x.Content).IsRequired();
        }
    }
}
