using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.Entity.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }  
        public int PreparationTime { get; set; }    
        public string Status { get; set; }  
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
