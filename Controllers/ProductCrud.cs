using McDonalds.Entity.Data;
using McDonalds.Entity.Interfaces;
using McDonalds.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.Controllers
{
    public class ProductCrud : ICrud<Product>
    {
        DataContext db =new DataContext();
        public bool Add(Product entity)
        {
            if (entity != null)
            {
                db.Products.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();

        }

        public Product GetById(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public bool Update(Product entity, int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                product.CategoryId = entity.CategoryId;
                product.Name = entity.Name;
                product.Image = entity.Image;
                product.Price = entity.Price;
                product.PreparationTime = entity.PreparationTime;
                db.Products.Add(product);
                db.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
