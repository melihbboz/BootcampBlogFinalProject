using BlogProject.Core;
using BlogProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Repository.Configurations
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("Posts");
            builder.Property(x => x.Title).IsRequired();

            builder.HasOne(x => x.Category).WithMany(x => x.Posts).HasForeignKey(x => x.CategoryId);
        }
    }
}
