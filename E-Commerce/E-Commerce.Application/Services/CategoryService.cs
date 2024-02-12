using E_Commerce.Application.Contracts;
using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class CategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category CreateCategory(Category category)
        {
            if (category is not null)
            {
                var cate = _categoryRepository.Create(category);
                _categoryRepository.Complete();
                return cate;
            }
            return null;
        }
        public Category UpdateCategory(Category category)
        {
            if (category is not null)
            {
                var cate = _categoryRepository.Update(category);
                _categoryRepository.Complete();
                return cate;
            }
            return null;
        }
        public bool DeleteCategory(Category category)
        {
            if (category is not null)
            {
                bool cate = _categoryRepository.Delete(category);
                _categoryRepository.Complete();
                return cate;
            }
            return false;
        }
        public IQueryable<Category> GetCategories()
        {
            return _categoryRepository.GetAll();
        }
        public Category GetCategory(int id)
        {
            if (id != 0)
            {
                return _categoryRepository.GetById(id);
            }
            return null;
        }
        public IQueryable<Category> SearchByName(string categoryName)
        {
            if (categoryName is not null)
            {
                return _categoryRepository.SearchByName(categoryName);
            }
            return null;
        }
        public IQueryable<Category> OrderByCategoryNameAsc()
        {
            return _categoryRepository.SortByNameAsc();
        }
        public IQueryable<Category> OrderByCategoryNameDesc()
        {
            return _categoryRepository.SortByNameDesc();
        }

    }
}
