using E_Commerce.Application.Contracts;
using E_Commerce.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            Complete();
            return entity;
        }

        public bool Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            Complete();
            return true;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public T Update(T entity)
        {
            _context.Update<T>(entity);
            Complete();
            return entity;
        }

    }
}
