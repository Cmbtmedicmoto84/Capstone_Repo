using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class ServiceAppointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string CustomerAddress { get; set; }
        public string AppointmentNotes { get; set; }
        public DateTime AppointmentTime { get; set; }
        public DateTime AppointmentDate { get; set; }
        public bool IsComplete { get; set; }

        //[ForeignKey("Customer")]
        //public int CustomerAccountId { get; set; }
        //public Customer Customer { get; set; }
    }
}
