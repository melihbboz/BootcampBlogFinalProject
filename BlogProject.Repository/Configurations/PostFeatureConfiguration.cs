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
    internal class PostFeatureConfiguration : IEntityTypeConfiguration<PostFeature>
    {
        public void Configure(EntityTypeBuilder<PostFeature> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Post).WithOne(x => x.PostFeature).HasForeignKey<PostFeature>(x => x.PostId);
        }
    }
}
