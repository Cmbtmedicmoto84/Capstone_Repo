using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class Customer
    {
        [Key]
        public int CustomerAccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
