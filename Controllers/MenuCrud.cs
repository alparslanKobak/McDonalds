using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.Entity.Data;
using McDonalds.Entity.Interfaces;
using McDonalds.Entity.Models;

namespace McDonalds.Controllers
{
    public class MenuCrud : ICrud<Menu>
    { DataContext db = new DataContext();
        public bool Add(Menu entity)
        {
            if (entity !=null)
            {
                db.Menus.Add(entity);   
                db.SaveChanges();   
                return true;
            }
            return false;   
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll()
        {
            return db.Menus.ToList();
        }

        public Menu GetById(int id)
        {
            return db.Menus.Find(id);   
        }

        public bool Update(Menu entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
