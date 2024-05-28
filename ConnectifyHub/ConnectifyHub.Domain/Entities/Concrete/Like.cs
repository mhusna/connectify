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
        public int AdmirerID { get; set; }
        public int PostID { get; set; }
        public DateTime LikedTime { get; set; }
        public Status EntityStatus { get; set; }
        public LikeStatus LikeStatus { get; set; }
    }
}
