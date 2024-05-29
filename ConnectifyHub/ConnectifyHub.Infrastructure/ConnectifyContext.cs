using ConnectifyHub.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure
{
    public class ConnectifyContext : IdentityDbContext<User>
    {
        public ConnectifyContext() { }

        public ConnectifyContext(DbContextOptions<ConnectifyContext> options)  :base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle(
                "Data Source =(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=oracl)));User Id=ConnectifyDB;Password=ConnectifyDB;"
            );
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<UserRelationship> UserRelationships { get; set; }
    }
}
