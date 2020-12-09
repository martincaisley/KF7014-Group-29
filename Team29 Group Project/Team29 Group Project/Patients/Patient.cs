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
        public  int PatientID { get; }
        [Required]
        public String firstName { get; set; }
        [Required]
        public  String lastName { get; set; }
        [Required]
        public DateTime DoB { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Occupation { get; set; }
        [Required]
        public String PhoneNum { get; set; }
        [Required]
        public String GPname { get; set; }
        [Required]
        public String GPaddress { get; set; }



    }
}
