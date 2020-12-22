using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    public interface IPatientDetailsModel
    {
        String getName(int patientID);
        DataTable getAppointmentList(int patientID);
        void deleteEntry(int appointmentID);
        bool messagesToView(int patientID);
        bool checkQuestionnaireDate(int patientID);
        bool checkRepeatOffences(int patientID);

    }
}
