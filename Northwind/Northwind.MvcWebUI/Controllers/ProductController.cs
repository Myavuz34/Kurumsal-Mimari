using Northwind.BLL.Concrete;
using Northwind.DAL.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Entities;

namespace Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {

        ProductManager _productManager = new ProductManager(new EfProductDal());
        public  ActionResult Index()
        {
            List<Product> products = _productManager.GetAll();
            return View(products);
        }
    }
}