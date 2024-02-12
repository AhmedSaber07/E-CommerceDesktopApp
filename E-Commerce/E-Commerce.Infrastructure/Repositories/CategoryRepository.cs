using E_Commerce.Application.Contracts;
using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Repositories
{
    public class CategoryRepository :BaseRepository<Category> , ICategoryRepository
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Category> SearchByName(string categoryName)
        {
            return _context.Categories.Where(C => C.Name == categoryName);
        }
        public IQueryable<Category> SortByNameAsc()
        {
            return _context.Categories.OrderBy(C => C.Name);
        }
        public IQueryable<Category> SortByNameDesc()
        {
            return _context.Categories.OrderByDescending(C => C.Name);
        }

    }
}
