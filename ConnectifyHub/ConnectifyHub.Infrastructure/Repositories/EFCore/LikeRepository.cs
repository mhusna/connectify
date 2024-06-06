using ConnectifyHub.Application.Interfaces.Repositories;
using ConnectifyHub.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure.Repositories.EFCore
{
    public class LikeRepository : GenericRepository<Like>, ILikeRepository
    {
        public LikeRepository(ConnectifyContext context) : base(context) { }
    }
}
