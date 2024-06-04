using ConnectifyHub.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure.CFGs
{
    public class UserCFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("ASPNETUSERS");

            builder.Property(u => u.FirstName)
                    .HasMaxLength(255);

            builder.Property(u => u.LastName)
                    .HasMaxLength(255);

            builder.Property(u => u.EmailConfirmed)
                   .HasColumnType("NUMBER(1)");

            builder.Property(u => u.PhoneNumberConfirmed)
                   .HasColumnType("NUMBER(1)");

            builder.Property(u => u.TwoFactorEnabled)
                   .HasColumnType("NUMBER(1)");

            builder.Property(u => u.LockoutEnabled)
                   .HasColumnType("NUMBER(1)");
        }
    }
}
