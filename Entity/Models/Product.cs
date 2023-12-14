using McDonalds.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.Entity.Models
{
    public class Product:CommonProperty
    {
        public int CategoryId { get; set; } 
        Category Category { get; set; } 
        public double Price { get; set; }   
        public int PreparationTime { get; set; }    

        public List<MenuProduct> MenuProducts { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }


    }
}
