using ConnectifyHub.Application.Interfaces.Repositories;
using ConnectifyHub.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure.Repositories.EFCore
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(ConnectifyContext context) : base(context) { }
    }
}
