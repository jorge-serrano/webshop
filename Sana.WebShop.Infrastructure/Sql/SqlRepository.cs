using System.Collections.Generic;
using System.Linq;
using Sana.WebShop.Model.Contracts;
using Sana.WebShop.Model.Data;

namespace Sana.WebShop.Infrastructure.Sql
{
    public class SqlRepository :IRepository
    {
        private readonly WebShopDbContext _db;

        public SqlRepository()
        {
            _db = new WebShopDbContext();
        }

        public int AddProduct(Product product)
        {
            _db.Product.Add(product);
            _db.SaveChanges();
            return product.ProductID;
        }

        public IList<Product> GetProducts()
        {
            return _db.Product.ToList();
        }
    }
}
