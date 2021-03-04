using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product {ProductId=1, CategoryId=1, ProductName="macbook", UnitsInStock=5, UnitPrice=10000},
                new Product { ProductId = 2, CategoryId = 2, ProductName = "kamera", UnitsInStock = 7, UnitPrice = 8000 },
                new Product { ProductId = 3, CategoryId = 3, ProductName = "mouse", UnitsInStock = 35, UnitPrice = 300 },
                new Product { ProductId = 4, CategoryId = 4, ProductName = "klavye", UnitsInStock = 40, UnitPrice = 800 },
                new Product { ProductId = 5, CategoryId = 5, ProductName = "telefon", UnitsInStock = 20, UnitPrice = 5000 }
            };
        }




        public void Add(Product product)
        {
            _products.Add(product);

        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
            
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Uptade(Product product)
        {
            Product productToUptade = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUptade.ProductName = product.ProductName;
            productToUptade.ProductId = product.ProductId;
            productToUptade.UnitsInStock = product.UnitsInStock;
            productToUptade.UnitPrice = product.UnitPrice;
            productToUptade.CategoryId = product.CategoryId;
        }
    }
}


