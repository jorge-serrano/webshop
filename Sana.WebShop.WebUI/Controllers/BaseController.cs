using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sana.WebShop.Infrastructure;
using Sana.WebShop.Model.Contracts;

namespace Sana.WebShop.WebUI.Controllers
{
    public class BaseController: Controller
    {
        public IRepository Repository { get; set; }
        public BaseController()
        {
            Repository = RepositoryFactory.GetRepository("");
        }
        public BaseController(string mode)
        {
            Repository = RepositoryFactory.GetRepository(mode);
        }
    }
}