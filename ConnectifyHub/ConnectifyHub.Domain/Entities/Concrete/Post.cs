using ConnectifyHub.Domain.Entities.Abstract;
using ConnectifyHub.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Domain.Entities.Concrete
{
    public class Post : IBaseEntity
    {
        public int ID { get; set; }
        public string PostContent { get; set; }
        public string PostContentImageUrl { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? EditTime { get; set; }
        public Status EntityStatus { get; set; }

        // Postu olusturan
        public int CreatorID { get; set; }
        public User Creator { get; set; }

        // Postun Begenileri
        public ICollection<Like>? Likes { get; set; }

        // Postun Yorumlari
        public ICollection<Comment>? Comments { get; set; }
    }
}
