using ConnectifyHub.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Domain.Entities.Abstract
{
    public interface IBaseEntity
    {
        public Status EntityStatus { get; set; }
    }
}
