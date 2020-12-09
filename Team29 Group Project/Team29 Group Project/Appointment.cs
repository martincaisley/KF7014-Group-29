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
        public string appointmentDate { get; set; }
        [Required]
        public string appointmentStartTime { get; set; }
        [Required]
        public string appointmentEndTime { get; set; }
        [Required]
        public string appointmentType { get; set; }
        [Required]
        public string appointmentLength { get; set; }

    }
}
