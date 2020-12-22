using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    public interface INewAppointmentsModel
    {
        string GetPatientName(int patientID);
        void AddAppointmentToDatabase(int patientID, DateTime appointmentDate, TimeSpan appointmentStartTime, TimeSpan appointmentEndTime, int appointmentLength, string appointmentType, string appointmentBand);
        int getAppointmentLength(string AppointmentT);
        DataTable getAppointmentsDT(DateTime AppDate);
        bool checkIfCanBookAtThisTime(DateTime selectedDate, TimeSpan selectedStartTime, TimeSpan selectedEndTime);
    }
}
