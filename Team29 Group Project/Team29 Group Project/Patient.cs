using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class Patient
    {
        [Key]
        public int patientID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public DateTime DoB { get; set; }
        public String email { get; set; }
        public String occupation { get; set; }
        public String GPname { get; set; }
        public String GPaddress { get; set; }
    }
}
