using ConnectifyHub.Domain.Entities.Abstract;
using ConnectifyHub.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Domain.Entities.Concrete
{
    public class UserRelationship
    {
        public int UserRelationshipID { get; set; }
        public DateTime RequestTime { get; set; }
        public DateTime? ResponseTime { get; set; } = null;
        public UserRelationshipStatus RelationshipStatus { get; set; }

        // Aksiyonu alan
        public int ActorID { get; set; }
        public User Actor { get; set; }

        // Etkilenen
        public int AffectedID { get; set; }
        public User Affected { get; set; }
    }
}