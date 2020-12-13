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
        int appLength;

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

        public void getAppointmentLength()
        {
            //NewAppointmentsScreen.setAppointmentEndTime(appointmentLength);
        }

        public void processAppointment()
        {
            int patientID = NewAppointmentsScreen.getPatientID();
            DateTime appointmentDate = NewAppointmentsScreen.getAppointmentDate();
            DateTime appointmentStartTime = NewAppointmentsScreen.getAppointmentStartTime();
            DateTime appointmentEndTime = NewAppointmentsScreen.getAppointmentEndTime();
            int appointmentLength = appLength;
            string appointmentType = NewAppointmentsScreen.getAppointmentType();

            newAppointmentsModel.WriteToDatabase(patientID, appointmentDate, appointmentStartTime, appointmentEndTime, appointmentLength, appointmentType);
        }

        public void getPatientName(int patientID)
        {
            NewAppointmentsScreen.setName(newAppointmentsModel.GetPatientName(patientID));
        }

        public void setAppType(string appType)
        {
            string appointmentType = appType;
            appLength = newAppointmentsModel.getAppointmentLength(appointmentType);
            NewAppointmentsScreen.setAppointmentEndTime(appLength);
        }

        // public void
    }
}

