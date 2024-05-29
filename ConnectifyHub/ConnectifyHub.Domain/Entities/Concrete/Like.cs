using ConnectifyHub.Domain.Entities.Abstract;
using ConnectifyHub.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Domain.Entities.Concrete
{
    public class Like: IBaseEntity
    {
        public int LikeID { get; set; }
        public DateTime LikedTime { get; set; }

        // Soft delete icin
        public Status EntityStatus { get; set; }
        
        // Like - Dislike
        public LikeStatus LikeStatus { get; set; }

        // Begenen kisi
        public string LikerID { get; set; }
        public User Liker { get; set; }

        // Begenilen gonderi
        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}
