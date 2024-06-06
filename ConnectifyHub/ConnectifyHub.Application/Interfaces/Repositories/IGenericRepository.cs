using ConnectifyHub.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class, IBaseEntity, new()
    {
        Task<ICollection<T>> GetAll(Expression<Func<T, bool>>? filter = null);
        Task<int> InsertEntity(T entity);
        Task<int> UpdateByEntity(T entity);
        Task<int> DeleteById(int id);
        Task<T> Find(Expression<Func<T, bool>> filter);
    }
}
