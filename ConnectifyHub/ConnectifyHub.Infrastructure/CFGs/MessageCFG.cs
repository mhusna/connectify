using ConnectifyHub.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure.CFGs
{
    public class MessageCFG : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("MESSAGES");

            builder.HasKey(m => new { m.SenderID, m.ReceiverID });

            builder.HasOne(m => m.Sender)
                   .WithMany(m => m.SentMessages)
                   .HasForeignKey(m => m.SenderID);

            builder.HasOne(m => m.Receiver)
                   .WithMany(m => m.ReceivedMessages)
                   .HasForeignKey(m => m.ReceiverID);
        }
    }
}
