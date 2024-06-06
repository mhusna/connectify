using ConnectifyHub.Application.Interfaces.Repositories;
using ConnectifyHub.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure.Repositories.EFCore
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ConnectifyContext context) : base(context) { }
    }
}
