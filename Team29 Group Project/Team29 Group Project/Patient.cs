using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team29_Group_Project
{
    abstract class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public DateTime DoB { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String Occupation { get; set; }
        public String GPname { get; set; }
        public String GPaddress { get; set; }



    }
}
