using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sana.WebShop.Infrastructure;
using Sana.WebShop.Model.Data;

namespace Sana.WebShop.WebUI.Controllers
{
    public class ProductsController : BaseController
    {
        private string _mode = "Memory";

        public ActionResult Index(string mode)
        {
            _mode = mode;
            this.ViewData["mode"] = _mode;
            Repository = RepositoryFactory.GetRepository(_mode);
            return View(Repository.GetProducts());
        }

        // GET: Products/Create
        public ActionResult Create(string mode)
        {
            _mode = mode;
            this.ViewData["mode"] = _mode;
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(string mode, FormCollection collection)
        {
            try
            {
                Repository = RepositoryFactory.GetRepository(mode);
                Product newProduct = new Product
                {
                    ProductName = collection["ProductName"],
                    ProductNumber = collection["ProductNumber"],
                    Price = Decimal.Parse(collection["Price"])
                };
                Repository.AddProduct(newProduct);
                return RedirectToAction("Index",new {mode=mode});
            }
            catch
            {
                return View();
            }
        }

        

        
    }
}
