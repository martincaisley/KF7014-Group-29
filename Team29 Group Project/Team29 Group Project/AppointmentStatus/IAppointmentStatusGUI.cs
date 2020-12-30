/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IAppointmentStatusGUI
    {
        void setPatientName(string name);
        void setAppointmentTime(TimeSpan appTime);
        void setAppointmentCost(double cost);
        void Register(AppointmentStatusPresenter ASP);
        int getAppointmentID();
        string getAppointmentStatus();


    }

}
