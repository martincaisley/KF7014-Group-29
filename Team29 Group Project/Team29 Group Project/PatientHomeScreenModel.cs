using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class PatientHomeScreenModel
    {
        public DataTable getDT()
        {
            DataTable dt = new DataTable();
            
            using (var context = new MyDBEntities())
            {
                //var patients = context.Patients.ToList();

                
                dt.Columns.Add("Patient ID", typeof(int));
                dt.Columns.Add("Patient Name", typeof(string));
                dt.Columns.Add("Patient Address", typeof(string));
                dt.Columns.Add("Patient Phone Number", typeof(string));

                /*
                var patientQuery = from p in patients.AsEnumerable()
                                   select dt.LoadDataRow(new object[]
                                   {
                                //p.PatientID,
                                //p.PatientName,
                                //p.PatientAddress,
                                //p.PatientPhoneNumber
                                   }, false);

                patientQuery.CopyToDataTable();
                */
                
            }
            
            return dt;
        }
    }
}
