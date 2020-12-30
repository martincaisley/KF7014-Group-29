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
    public interface IContactedByPhoneGUI
    {
        void setPatientName(string name);
        void setAppointmentDate(DateTime date);
        void setAppointmentTime(TimeSpan time);
        void Register(ContactedByPhonePresenter CBPP);
        int getAppointmentID();
        void confirmationMessage();
    }
}
