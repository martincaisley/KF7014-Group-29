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
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                var patients = unitOfWork.patient.GetAll();
                
                dt.Columns.Add("PatientID", typeof(int));
                dt.Columns.Add("Patient Name", typeof(string));
                dt.Columns.Add("Patient Phone Number", typeof(string));


                var patientQuery = from p in patients.AsEnumerable()
                                   select dt.LoadDataRow(new object[]
                                   {
                                           p.PatientID,
                                p.firstName + " " + p.lastName,
                                p.PhoneNum
                                   }, false);

                patientQuery.CopyToDataTable();
            }
            catch (Exception e)
            {
                Console.WriteLine("Home Screen Exception: " + e.Message);
                //add in exception here
            }
            return dt;
        }
    }
}
