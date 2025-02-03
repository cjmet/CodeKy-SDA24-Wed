using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    // C# 12 Primary Constructor syntax
    public class ProductRepository : IProductRepository
    {
        public bool VerboseSQL { get; set; }
        public string DbPathName { get { return _context.DbPathName; }  }

        private SQLiteContext _context { get; set; }

        public ProductRepository()
        {
            _context = new SQLiteContext();
            if (_context == null) throw new ArgumentNullException(nameof(_context));
        }
        
        public ProductRepository(SQLiteContext context)
        {
            _context = context;
            if (_context == null) throw new ArgumentNullException(nameof(_context));
        }

        public void ResetDatabase()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }

        public IProduct? AddProduct(IProduct product)
        {
            // Implementation for adding a product
            if (product == null) return null;
            product.Id = 0; 
            int count = _context.Products.Count();
            _context.Products.Add((Product)product);
            _context.SaveChanges();
            Boolean results = count < _context.Products.Count();
            return results ? product : null;
        }

        public IProduct? GetProduct(int id)
        {
            // Implementation for getting a product by id
            return _context.Products.Find(id);
        }

        public IProduct? UpdateProduct(IProduct product)
        {
            // Implementation for updating a product
            if (product == null) return null;
            if (product.Id == 0) return null;

            Product entity = _context.Products.Find(product.Id);
            if (entity == null) return null;

            entity = (Product) product;
            _context.SaveChanges();

            return entity;
        }

        public Boolean DeleteProduct(int Id)
        {
            // Implementation for deleting a product
            Product entity = _context.Products.Find(Id);
            if (entity == null) return false;

            var count = _context.Products.Count();
            _context.Products.Remove(entity);
            _context.SaveChanges();

            return count > _context.Products.Count();
        }

        public List<IProduct> GetAllProducts()
        {
            // Implementation for getting all products
            List<IProduct> list = _context.Products.Cast<IProduct>().ToList();
            return list;
        }
    }
}
