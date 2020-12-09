using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class Appointment
    {
        [Key]
        public int appointmentID { get; set; }
        [Required]
        public int patientID { get; set; }
        [Required]
        public DateTime appointmentDate { get; set; }
        [Required]
        public DateTime appointmentStartTime { get; set; }
        [Required]
        public DateTime appointmentEndTime { get; set; }
        [Required]
        public string appointmentType { get; set; }
        [Required]
        public int appointmentLength { get; set; }
        [Required]
        public string arrivedToAppointment { get; set; }
        [Required]
        public string contacted { get; set; }
    }
}
