using McDonalds.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.Entity.Models
{
    public class Category:CommonProperty
    {
        public List<Product> Products { get; set; }
    }
}
