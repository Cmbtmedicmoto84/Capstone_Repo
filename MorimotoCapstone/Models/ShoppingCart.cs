using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double CartTotal { get; set; }
        public Product Product { get; set; }
    }
}
