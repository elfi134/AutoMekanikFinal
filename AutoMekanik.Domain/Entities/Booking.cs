using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMekanik.Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Car field is required.")]
        public int CarId { get; set; }

        [Required(ErrorMessage = "The Mechanic field is required.")]
        public int MechanicId { get; set; }

        [Required(ErrorMessage = "The Appointment Date field is required.")]
        public DateTime AppointmentDate { get; set; }

        public virtual Car? Car { get; set; } =null ;
        public virtual Mechanic? Mechanic { get; set; } = null;
    }

}


