using BlogProject.Core;
using BlogProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Repository.Seeds
{
    internal class PostSeed : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(new Post
            {
                Id=1,
                CategoryId=1,
                Title="Blog Title 1",
                Description="Blog Description",
                Body="Blog Body 1",
                ImagePath="1.jpg",
                CreatedDate=DateTime.Now
            },
            new Post
            {
                Id = 2,
                CategoryId = 2,
                Title = "Blog Title 2",
                Description = "Blog Description",
                Body = "Blog Body 2",
                ImagePath = "2.jpg",
                CreatedDate = DateTime.Now
            },
            new Post
            {
                Id = 3,
                CategoryId = 3,
                Title = "Blog Title 3",
                Description = "Blog Description",
                Body = "Blog Body 3",
                ImagePath = "3.jpg",
                CreatedDate = DateTime.Now
            },
            new Post
            {
                Id = 4,
                CategoryId = 3,
                Title = "Blog Title 4",
                Description = "Blog Description",
                Body = "Blog Body 4",
                ImagePath = "4.jpg",
                CreatedDate = DateTime.Now
            });
        }
    }
}
