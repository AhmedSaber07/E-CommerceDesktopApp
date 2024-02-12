using E_Commerce.Application.Contracts;
using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class ProductService 
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product CreateProduct(Product product)
        {
            if (product is not null)
            {
                var prod = _productRepository.Create(product);
                _productRepository.Complete();
                return prod;
            }
            return null;
        }
        public Product UpdateProduct(Product product)
        {
            if (product is not null)
            {
                var prod = _productRepository.Update(product);
                _productRepository.Complete();
                return prod;
            }
            return null;
        }
        public bool DeleteProduct(Product product)
        {
            if (product is not null)
            {
                bool prod = _productRepository.Delete(product);
                _productRepository.Complete();
                return prod;
            }
            return false;
        }
        public IQueryable<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }
        public Product GetProduct(int id)
        {
            if (id != 0)
            {
                return _productRepository.GetById(id);
            }
            return null;
        }
        public IQueryable<Product> SearchByName(string productName)
        {
            if (productName is not null)
            {
                return _productRepository.SearchByName(productName);
            }
            return null;
        }
        public IQueryable<Product> OrderByProductNameAsc()
        {
            return _productRepository.SortByNameAsc();
        }
        public IQueryable<Product> OrderByProductNameDesc()
        {
            return _productRepository.SortByNameDesc();
        }
        public IQueryable<Product> OrderByProductPriceAsc()
        {
            return _productRepository.SortByPriceAsc();
        }
        public IQueryable<Product> OrderByProductPriceDesc()
        {
            return _productRepository.SortByPriceDesc();
        }

    }
}
