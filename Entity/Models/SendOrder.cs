using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.Entity.Models
{
    public class SendOrder
    {
        public int Id { get; set; }

        public string OrderStatus { get; set; }

        public List<OrderProduct> Products { get; set; }
    }
}
