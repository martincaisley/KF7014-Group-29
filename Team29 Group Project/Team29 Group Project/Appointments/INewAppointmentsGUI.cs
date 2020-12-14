using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Team29_Group_Project
{
    public interface INewAppointmentsGUI
    {
        int getPatientID();
        DateTime getAppointmentDate();
        TimeSpan getAppointmentStartTime();
        TimeSpan getAppointmentEndTime();
        string getAppointmentType();
        void setName(string name);
        void Register(NewAppointmentsPresenter NAP);
        void setAppointmentEndTime(int appointmentLength);
        void setDGV(DataTable DT);
    }
}
