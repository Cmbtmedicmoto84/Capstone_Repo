using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Price")]
        public double ProductPrice { get; set; }

        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        internal object find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
