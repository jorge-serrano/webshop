using System.Collections.Generic;
using Sana.WebShop.Model.Data;

namespace Sana.WebShop.Model.Contracts
{
    public interface IRepository
    {
        int AddProduct(Product product);
        IList<Product> GetProducts();
    }
}