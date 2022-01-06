using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.EntityConfigurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired();

            builder.HasOne(x => x.User).WithMany(x => x.Topics).HasForeignKey(x => x.UserId).IsRequired();

            builder.HasOne(x => x.Category).WithMany(x => x.Topics).HasForeignKey(x => x.CategoryId).IsRequired();
        }
    }
}
