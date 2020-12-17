using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class AppointmentStatusModel
    {
        public string setName(int appointmentID)
        {

            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var app = unitOfWork.appointment.GetByID(appointmentID);
            var pat = unitOfWork.patient.GetByID(app.patientID);

            string patientName = pat.firstName + " " + pat.lastName;
            return patientName;
        }
        public TimeSpan setTime(int appointmentID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.appointment.GetByID(appointmentID);
            TimeSpan time = UOW.appointmentStartTime;

            return time;
        }
        public double setCost(int appointmentID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.appointment.GetByID(appointmentID);
            double cost = UOW.appointmmentCost;

            return cost;
        }
        public void updateTable(int appointmentID, string value)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            Appointment a = unitOfWork.appointment.GetByID(appointmentID);
            a.arrivedToAppointment = value;
            unitOfWork.Save();
        }
    }
}
