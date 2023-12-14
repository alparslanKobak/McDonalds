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
    internal class OrderCrud : ICrud<Order>
    {   DataContext db = new DataContext();     
        public bool Add(Order entity)
        {
            if (entity != null)
            {
                db.Orders.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return db.Orders.Find(id);
        }

        public bool Update(Order entity, int id)
        {
            var item = GetById(id);
            if (item!= null)
            {
                item.Status = entity.Status;
                item.PreparationTime = entity.PreparationTime;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
