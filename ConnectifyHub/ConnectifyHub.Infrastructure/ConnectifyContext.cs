using ConnectifyHub.Domain.Entities.Concrete;
using ConnectifyHub.Domain.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure
{
    public class ConnectifyContext : IdentityDbContext<User>
    {
        public ConnectifyContext() { }

        public ConnectifyContext(DbContextOptions<ConnectifyContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle(
                "Data Source =(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=oracl)));User Id=ConnectifyDB;Password=ConnectifyDB;"
            );
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<UserRelationship> UserRelationships { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            var creatorID = Guid.NewGuid().ToString();
            var creator = new User()
            {
                Id = creatorID,
                FirstName = "Yusuf",
                LastName = "Ziya",
                Email = "yusuf@gmail.com",
                UserName = "yziya",
                NormalizedEmail = "YUSUF@GMAIL.COM",
                NormalizedUserName = "YZIYA",
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            var hashedPasswordCreator = new PasswordHasher<User>().HashPassword(creator, "12345");
            creator.PasswordHash = hashedPasswordCreator;

            var likerID = Guid.NewGuid().ToString();
            var liker = new User()
            {
                Id = likerID,
                FirstName = "Erkut",
                LastName = "Ates",
                Email = "erkut@gmail.com",
                UserName = "eates",
                NormalizedEmail = "ERKUT@GMAIL.COM",
                NormalizedUserName = "EATES",
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            var hashedPasswordLiker = new PasswordHasher<User>().HashPassword(liker, "54321");
            liker.PasswordHash = hashedPasswordLiker;

            var commentorID = Guid.NewGuid().ToString();
            var commentor = new User()
            {
                Id = commentorID,
                FirstName = "Husna",
                LastName = "Kisla",
                Email = "husna@gmail.com",
                UserName = "hkisla",
                NormalizedEmail = "HUSNA@GMAIL.COM",
                NormalizedUserName = "HKISLA",
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            var hashedPasswordCommentor = new PasswordHasher<User>().HashPassword(commentor, "98765");
            commentor.PasswordHash = hashedPasswordLiker;

            var post = new Post()
            {
                ID = 1,
                CreatorID = 1,
                PostContent = "Merhaba Dunya",
                PostContentImageUrl = "hello_world.png",
                CreatedTime = DateTime.Now,
                EditTime = null,
                EntityStatus = Status.Active,
                Comments = null,
                Likes = null,
            };

            var comment = new Comment()
            {
                ID = 1,
                PostID = 1,
                CommentorID = commentorID,
                CommentContent = "Ilk yorum",
                CommentCreateTime = DateTime.Now,
                CommentEditTime = null,
                EntityStatus = Status.Active,
            };

            var like = new Like()
            {
                ID = 1,
                LikerID = likerID,
                EntityStatus = Status.Active,
                LikedTime = DateTime.Now,
                LikeStatus = LikeStatus.Like,
                PostID = 1,
            };

            //post.Comments.Add(comment);
            //post.Likes.Add(like);

            builder.Entity<User>().HasData(creator, liker, commentor);
            builder.Entity<Post>().HasData(post);
            builder.Entity<Like>().HasData(like);
            builder.Entity<Comment>().HasData(comment);
        }
    }
}
