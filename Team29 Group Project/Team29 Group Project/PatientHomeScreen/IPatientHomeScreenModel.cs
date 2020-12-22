using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IPatientHomeScreenModel
    {
        DataTable getPatientsDT();
        void deleteEntry(int patientID);

    }
}
