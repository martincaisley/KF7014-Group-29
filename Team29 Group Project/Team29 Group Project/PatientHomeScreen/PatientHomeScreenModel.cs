using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class PatientHomeScreenModel : IPatientHomeScreenModel
    {
        public DataTable getPatientsDT()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            DataTable dt = new DataTable();
            try
            {
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
                Console.WriteLine("Exception in PatientHomeScreenModel: " + e.Message);
            }
            unitOfWork.Dispose();
            return dt;
        }
        public void deleteEntry(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            Patient patientToDelete = unitOfWork.patient.GetByID(patientID);
            unitOfWork.patient.Remove(patientToDelete);
            unitOfWork.Save();
            unitOfWork.Dispose();
        }
    }
}
