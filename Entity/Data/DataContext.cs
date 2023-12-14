using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using McDonalds.Entity.Models;

namespace McDonalds.Entity.Data
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DbConnection") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }   
        public DbSet<Product> Products { get; set; }
        public DbSet<MenuProduct> MenuProducts { get; set; }
        public DbSet<Order> Orders { get; set; }    
        public DbSet<OrderProduct> OrderProducts { get; set; }


    }
}
