using Northwind.DAL.Absract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        private readonly NorthwindContext _context = new NorthwindContext();
        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public void Delete(int productId)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(p => p.ProductID == productId));
            _context.SaveChanges();
        }

        public Product Get(int productId)
        {
            return _context.Products.FirstOrDefault(x => x.ProductID == productId);
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _context.Products.FirstOrDefault(x => x.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            _context.SaveChanges();
        }
    }
}
