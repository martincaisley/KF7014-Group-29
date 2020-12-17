using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team29_Group_Project
{
   public class MedicalQuestionnaire
    {
        [Key]
        public int questionnaireID { get; set; }
       
        public String medicalConditions { get; set; }
       
        public String medication { get; set; }
       
        public String allergies { get; set; }
        [Required]
        public int patientID { get; set; }
        public DateTime DateCompleted { get; set; }
       
    }
}
