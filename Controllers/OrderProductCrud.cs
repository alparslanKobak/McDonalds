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
    internal class OrderProductCrud : ICrud<OrderProduct>
    {   DataContext db = new DataContext(); 
        public bool Add(OrderProduct entity)
        {
            if (entity != null)
            {
                db.OrderProducts.Add(entity);
                db.SaveChanges();   
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> GetAll()
        {
            return db.OrderProducts.ToList();
        }

        public OrderProduct GetById(int id)
        {
            return db.OrderProducts.Find(id);
            
        }

        public bool Update(OrderProduct entity, int id)
        {
            OrderProduct item = GetById(id); if (item != null) {
                    item.Quantity ++;
                db.SaveChanges();
                return true;
            }
            return false;
            
        }
    }
}
