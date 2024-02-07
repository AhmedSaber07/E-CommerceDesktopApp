using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contracts
{
    public interface IBaseRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        bool Delete(T entity);
        IQueryable<T> GetAll();
        T GetById(int id);
        int Complete();
    }
}
