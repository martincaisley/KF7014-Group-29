using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IMessagesModel
    {
        int getAppointmentID(int patientID);
        string getName(int patientID);
        DateTime getDate(int patientID);
        TimeSpan getTime(int patientID);
        void updateTables(int appointmentID, string value);
        bool checkForRepeatOffence(int patientID);
    }
}
