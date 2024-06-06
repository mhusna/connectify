using ConnectifyHub.Application.Interfaces.Repositories;
using ConnectifyHub.Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Infrastructure.Repositories.EFCore
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly ConnectifyContext _context;
        protected DbSet<T> _dbSet;
        public GenericRepository(ConnectifyContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<int> DeleteById(int id)
        {
            T entity = await Find(x => x.ID == id);
            _dbSet.Remove(entity);

            return await _context.SaveChangesAsync() > 0 ? id : 0;
        }

        public async Task<T> Find(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.SingleOrDefaultAsync(filter);
        }

        public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>>? filter)
        {
            return filter != null ? await _dbSet.Where(filter).ToListAsync() : await _dbSet.ToListAsync();
        }

        public async Task<int> InsertEntity(T entity)
        {
            _dbSet.Add(entity);
            return await _context.SaveChangesAsync() > 0 ? entity.ID : 0;
        }

        public async Task<int> UpdateByEntity(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0 ? entity.ID : 0;
        }
    }
}
