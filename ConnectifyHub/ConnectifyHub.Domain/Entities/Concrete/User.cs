using ConnectifyHub.Domain.Entities.Abstract;
using ConnectifyHub.Domain.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Domain.Entities.Concrete
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ProfilePhotoUrl { get; set; }

        // Begenilen postlar.
        public ICollection<Like>? Likes { get; set; }

        // Yorum yapilan postlar.
        public ICollection<Comment>? Comments { get; set; }

        // Kullanıcının oluşturduğu postlar.
        public ICollection<Post> Posts { get; set; }

        // Kullanıcının gönderdiği mesajlar
        public ICollection<Message> SentMessages { get; set; }

        // Kullanıcının aldığı mesajlar
        public ICollection<Message> ReceivedMessages { get; set; }
    }
}
