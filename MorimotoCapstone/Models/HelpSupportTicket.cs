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
        public string CustomerName { get; set; }
        public string CustomerComments { get; set; }
        public bool IsResolved { get; set; }
        
        //[ForeignKey("Customer")]
        //public int CustomerAccountId { get; set; }
        //public Customer Customer { get; set; }

        //[ForeignKey("Product")]
        //public int ProductId { get; set; }
        //public Product Product { get; set; }
    }
}
