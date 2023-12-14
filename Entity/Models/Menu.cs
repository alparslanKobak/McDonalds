using McDonalds.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.Entity.Models
{
    public class Menu:CommonProperty
    {
        public double Price { get; set; }   
        public List<MenuProduct> MenuProducts { get; set; } 
    }
}
