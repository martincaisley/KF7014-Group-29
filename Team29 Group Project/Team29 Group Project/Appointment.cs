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
        public int patientID { get; set; }
        public string appointmentDate { get; set; }
        public string appointmentStartTime { get; set; }
        public string appointmentEndTime { get; set; }
        public string appointmentType { get; set; }
        public string appointmentLength { get; set; }
    }
}
