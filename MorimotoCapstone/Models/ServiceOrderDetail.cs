using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class ServiceOrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double ProductPrice { get; set; }
        public virtual ServiceInstallOrder ServiceInstallOrder { get; set; }
        public virtual Product Product { get; set; }
    }
}
