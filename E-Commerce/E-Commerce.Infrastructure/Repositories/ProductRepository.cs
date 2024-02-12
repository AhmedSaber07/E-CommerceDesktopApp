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
    public class ProductRepository : BaseRepository<Product> , IProductRepository
    {
         private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
        public IQueryable<Product> SearchByName(string productName)
        {
            return _context.Products.Where(s => s.Name == productName);
        }

        public IQueryable<Product> SortByNameAsc()
        {
            return _context.Products.OrderBy(p=>p.Name);
        }
        public IQueryable<Product> SortByNameDesc()
        {
            return _context.Products.OrderByDescending(p=>p.Name);
        }

        public IQueryable<Product> SortByPriceAsc()
        {
            return _context.Products.OrderBy(p => p.Price);
        }
        public IQueryable<Product> SortByPriceDesc()
        {
            return _context.Products.OrderByDescending(p => p.Price);
        }
    }
}
