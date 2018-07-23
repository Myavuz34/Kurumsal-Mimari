using Northwind.BLL.Concrete;
using Northwind.DAL.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Entities;
using Northwind.Interfaces;

namespace Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public  ActionResult Index()
        {
            List<Product> products = _productService.GetAll();
            return View(products);
        }
    }
}