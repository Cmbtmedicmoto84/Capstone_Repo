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

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Price")]
        public double ProductPrice { get; set; }

        [Display(Name = "Order Total")]
        public double CartTotal { get; set; }

        public Product Product { get; set; }
    }
}
