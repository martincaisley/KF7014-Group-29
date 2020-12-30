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
using System.Data;

namespace Team29_Group_Project
{
    public interface IPatientDetailsGUI
    {
        void setLabel(string patientName);
        void Register(PatientDetailsPresenter PDP);
        void setDGV(DataTable dt);
        void setLabelToBeRemoved(string patientName);
        void setButtonRed();
        void setButtonNormal();
        int getPatientID();
        void messagesButton_hide();
        void messagesButton_show();
        void noAppointmentsToShow();
    }
}
