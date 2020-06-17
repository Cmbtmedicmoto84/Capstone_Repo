using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class ServiceInstallOrder
    {
        [Key]
        public int OrderId { get; set; }
        public string ServiceOrderStatus { get; set; }
        public string OrderNotes { get; set; }
        public bool IsComplete { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Customer")]
        public int CustomerAccountId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("InstallTech")]
        public int TechId { get; set; }
        public InstallTech InstallTech { get; set; }
    }
}
