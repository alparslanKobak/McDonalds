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
    internal class MenuProductCrud : ICrud<MenuProduct>
    {
        DataContext db = new DataContext(); 
        public bool Add(MenuProduct entity)
        {
            if (entity !=null)
            {
                db.MenuProducts.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;   
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MenuProduct> GetAll()
        {
           return db.MenuProducts.ToList();
        }

        public MenuProduct GetById(int id)
        {
            return db.MenuProducts.Find(id);
        }

        public bool Update(MenuProduct entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
