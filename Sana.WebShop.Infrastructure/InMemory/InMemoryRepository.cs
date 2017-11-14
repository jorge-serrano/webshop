using System.Collections.Generic;
using System.Linq;
using Sana.WebShop.Model.Contracts;
using Sana.WebShop.Model.Data;

namespace Sana.WebShop.Infrastructure.InMemory
{
    public class InMemoryRepository : IRepository
    {
         static InMemoryRepository()
        {
            Products = new List<Product>();
            //Products.Add(new Product { Price = 10, ProductName = "Test Product", ProductNumber = "A001"});
        }

        private static InMemoryRepository _default;

        public static InMemoryRepository DefaultInstance => _default ?? (_default = new InMemoryRepository());
        public static IList<Product> Products { get; set; }

        public int AddProduct(Product product)
        {
            if (product.ProductID < 1)
                product.ProductID = GetNextProductId();
            Products.Add(product);
            return product.ProductID;
        }

        private static int GetNextProductId()
        {
            if(Products.Any())
                return (Products.Max(p => p.ProductID)) + 1;
            return 1;
        }

        public IList<Product> GetProducts()
        {
            return Products;
        }

    }
}
