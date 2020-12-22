using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IAppointment
    {
        int appointmentID { get; set; }
        int patientID { get; set; }
        DateTime appointmentDate { get; set; }
        TimeSpan appointmentStartTime { get; set; }
        TimeSpan appointmentEndTime { get; set; }
        string appointmentType { get; set; }
        int appointmentLength { get; set; } 
        string arrivedToAppointment { get; set; }
        string contacted { get; set; }         
        double appointmmentCost { get; set; }
    }
}
