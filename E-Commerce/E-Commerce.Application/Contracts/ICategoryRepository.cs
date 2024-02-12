using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contracts
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        IQueryable<Category> SearchByName(string categoryName);
        IQueryable<Category> SortByNameAsc();
        IQueryable<Category> SortByNameDesc();

    }
}
