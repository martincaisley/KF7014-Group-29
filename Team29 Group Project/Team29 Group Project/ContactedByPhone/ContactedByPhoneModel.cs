using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class ContactedByPhoneModel : IContactedByPhoneModel
    {
        UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
        public string setName(int appointmentID)
        {
            var app = unitOfWork.appointment.GetByID(appointmentID);
            var pat = unitOfWork.patient.GetByID(app.patientID);

            string patientName = pat.firstName + " " + pat.lastName;
            return patientName;
        }
        public DateTime setDate(int appointmentID)
        {
            var UOW = unitOfWork.appointment.GetByID(appointmentID);
            DateTime date = UOW.appointmentDate;

            return date;
        }
        public TimeSpan setTime(int appointmentID)
        {
            var UOW = unitOfWork.appointment.GetByID(appointmentID);
            TimeSpan time = UOW.appointmentStartTime;

            return time;
        }
        
        public void setToContacted(int appointmentID)
        {
            Appointment a = unitOfWork.appointment.GetByID(appointmentID);
            a.contacted = "Yes";
            unitOfWork.Save();
        }
    }
}
