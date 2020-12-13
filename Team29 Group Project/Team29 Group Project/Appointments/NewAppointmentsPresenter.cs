using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class NewAppointmentsPresenter
    {
        private NewAppointmentsModel newAppointmentsModel;
        private INewAppointmentsGUI NewAppointmentsScreen;

        public NewAppointmentsPresenter(INewAppointmentsGUI NewAppointmentsScreen)
        {
            this.NewAppointmentsScreen = NewAppointmentsScreen;
            NewAppointmentsScreen.Register(this);
            newAppointmentsModel = new NewAppointmentsModel();
            initializeForm();
        }

        private void initializeForm()
        {
           
        }

        public void processAppointment()
        {
            int patientID = NewAppointmentsScreen.getPatientID();
            DateTime appointmentDate = NewAppointmentsScreen.getAppointmentDate();
            DateTime appointmentStartTime = NewAppointmentsScreen.getAppointmentStartTime();
            DateTime appointmentEndTime = NewAppointmentsScreen.getAppointmentEndTime();
            string appointmentType = NewAppointmentsScreen.getAppointmentType();

            newAppointmentsModel.WriteToDatabase(patientID, appointmentDate, appointmentStartTime, appointmentEndTime, appointmentType);
        }

        public void getPatientName(int patientID)
        {
            NewAppointmentsScreen.setName(newAppointmentsModel.GetPatientName(patientID));
        }

       // public void
    }
}

