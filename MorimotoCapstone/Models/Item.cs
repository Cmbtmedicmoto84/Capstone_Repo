using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class Item
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double ProductPrice { get; set; }
    }
}
