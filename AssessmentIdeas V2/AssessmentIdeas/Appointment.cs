using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentIdeas
{
    public class Appointment
    {
        [Key]
        public int appointmentID { get; set; }
        public int patientID { get; set; }
        public string appointmentDate { get; set; }
        public string appointmentTime { get; set; }
        public GroupBox appointmentType { get; internal set; }
    }
}
