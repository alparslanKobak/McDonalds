using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.Entity.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        Order Order { get; set; }
        public int ProductId { get; set; }
        Product Product { get; set; }
        public int Quantity { get; set; }

        [NotMapped]
        public string Name
        {
            get; set;
        }
    }
}
