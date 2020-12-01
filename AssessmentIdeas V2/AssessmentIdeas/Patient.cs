using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssessmentIdeas
{
    class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }
        public string PatientPhoneNumber { get; set; }

    }
}
