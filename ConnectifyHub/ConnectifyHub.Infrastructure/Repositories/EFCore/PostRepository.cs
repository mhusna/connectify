using ConnectifyHub.Application.Interfaces.Repositories;
using ConnectifyHub.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure.Repositories.EFCore
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(ConnectifyContext context) : base(context) { }
    }
}
