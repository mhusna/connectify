using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        ICollection<T> GetAll();
        int UpdateByEntity(T entity);
        int DeleteById(int id);
        T FindByIntId(int id);
        T FindByStringId(string id);
    }
}
