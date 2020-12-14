using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class MissedAppointments
    {
        [Key]
        public int missedAppointmentID { get; set; }
        [Required]
        public int patientID { get; set; }
        [Required]
        public string appointmentID { get; set; }
    }
}
