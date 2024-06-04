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
    public class LikeCFG : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.ToTable("LIKES");

            builder.Property(like => like.ID)
                   .UseIdentityColumn(2, 1);
        }
    }
}
