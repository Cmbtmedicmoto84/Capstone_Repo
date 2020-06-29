using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MorimotoCapstone.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderDetailId { get; set; }
        [Required]
        public int OrderId { get; set; }

        [Required]
        public DateTime AppointmentTime { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }

        public Customer Customer { get; set; }
        public ServiceOrderDetail ServiceOrderDetail { get; set; }
        public ServiceInstallOrder ServiceInstallOrder { get; set; }
    }
}
