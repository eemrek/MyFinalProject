using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product {ProductId=1, CategoryId=1, ProductName="macbook", UnitsInStock=5, UnıtPrice=10000},
                new Product { ProductId = 2, CategoryId = 2, ProductName = "kamera", UnitsInStock = 7, UnıtPrice = 8000 },
                new Product { ProductId = 3, CategoryId = 3, ProductName = "mouse", UnitsInStock = 35, UnıtPrice = 300 },
                new Product { ProductId = 4, CategoryId = 4, ProductName = "klavye", UnitsInStock = 40, UnıtPrice = 800 },
                new Product { ProductId = 5, CategoryId = 5, ProductName = "telefon", UnitsInStock = 20, UnıtPrice = 5000 }
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

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
            
        }

        public void Uptade(Product product)
        {
            Product productToUptade = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUptade.ProductName = product.ProductName;
            productToUptade.ProductId = product.ProductId;
            productToUptade.UnitsInStock = product.UnitsInStock;
            productToUptade.UnıtPrice = product.UnıtPrice;
            productToUptade.CategoryId = product.CategoryId;
        }
    }
}


