using ConnectifyHub.Domain.Entities.Abstract;
using ConnectifyHub.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Domain.Entities.Concrete
{
    public class Comment: IBaseEntity
    {
        public int CommentID { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentCreateTime { get; set; }
        public DateTime CommentEditTime { get; set; }
        public Status EntityStatus { get; set; }

        // Yorumu yazan kisi
        public int CommentorID { get; set; }
        public User Commentor { get; set; }

        // Yorum yazilan gonderi
        public int PostID { get; set; }
        public Post Post { get; set; }

    }
}
