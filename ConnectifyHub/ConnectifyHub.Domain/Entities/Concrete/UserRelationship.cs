﻿using ConnectifyHub.Domain.Entities.Abstract;
using ConnectifyHub.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Domain.Entities.Concrete
{
    public class UserRelationship : IBaseEntity
    {
        public int ID { get; set; }
        public DateTime RequestTime { get; set; }
        public DateTime? ResponseTime { get; set; } = null;
        public UserRelationshipStatus RelationshipStatus { get; set; }
        public Status EntityStatus { get; set; }

        // Aksiyonu alan
        public string ActorID { get; set; }
        public User Actor { get; set; }

        // Etkilenen
        public string AffectedID { get; set; }
        public User Affected { get; set; }
    }
}