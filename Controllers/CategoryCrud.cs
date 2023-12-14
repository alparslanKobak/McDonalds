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
    internal class CategoryCrud : ICrud<Category>
    {
        DataContext db =new DataContext();
        public bool Add(Category entity)
        {
            if(entity != null)
            {
                db.Categories.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();

        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            var category = db.Categories.Find(id);
            if(category != null)
            {
                return category;
            }
            return null;
        }

        public bool Update(Category entity, int id)
        {
            var category = GetById(id);
            if (category!=null)
            {
                category.Name = entity.Name;
                category.Image=entity.Image;
                db.Categories.Add(category);
                db.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
