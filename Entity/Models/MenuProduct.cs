using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.Entity.Models
{
    public class MenuProduct
    {
        public int Id { get; set; } 
        public int ProductId { get; set; }  
        Product Product { get; set; }   
        public int MenuId { get; set; } 
        Menu Menu { get; set; }
    }
}
