using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class HelpSupportTicket
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "Customer name is required.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Display(Name = "What can we help you with today?")]
        public string CustomerComments { get; set; }


        public bool IsResolved { get; set; }

        //[ForeignKey("Customer")]
        //public int CustomerAccountId { get; set; }
        //public Customer Customer { get; set; }

        //public IEnumerable<Customer> Customers { get; set; }

        //[ForeignKey("Product")]
        //public int ProductId { get; set; }
        //public Product Product { get; set; }

        //public IEnumerable<Product> Products { get; set; }
    }
}
