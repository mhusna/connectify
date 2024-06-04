using ConnectifyHub.Domain.Entities.Concrete;
using ConnectifyHub.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure.CFGs
{
    public class PostCFG : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("POSTS");

            builder.Property(post => post.ID)
                   .UseIdentityColumn(2, 1);
        }
    }
}
