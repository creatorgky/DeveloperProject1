using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { CategoryId = 1, ProductId = 1, ProductName = "Dumbell", UnitPrice = 50, UnitsInStock = 10 },
                new Product { CategoryId = 2, ProductId = 2, ProductName = "Bar", UnitPrice = 50, UnitsInStock = 10 },
                new Product { CategoryId = 3, ProductId = 3, ProductName = "Sehpa", UnitPrice = 200, UnitsInStock = 1 },
                new Product { CategoryId = 4, ProductId = 4, ProductName = "BoxEldiveni", UnitPrice = 30, UnitsInStock = 25 },
                new Product { CategoryId = 4, ProductId = 5, ProductName = "Bandaj", UnitPrice = 10, UnitsInStock = 50 }
              };
        }   
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryId == categoryId).ToList();

        }

        public void Update(Product product)
        {
            //Gönderdiğimiz ürün ile eşit id'e sahip olan ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);


        }
    }
}
