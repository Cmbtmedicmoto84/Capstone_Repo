using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public double CartTotal { get; set; }
    }
}
