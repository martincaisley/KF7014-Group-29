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
    public interface IPatientHomeScreenGUI
    {
        void setDGV(DataTable dt);
        void Register(PatientHomeScreenPresenter PHSP);
        void viewPatient(int patientID);
        void noPatientsToShow();
    }
}
