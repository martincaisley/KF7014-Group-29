using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class AppointmentStatusPresenter
    {
        private AppointmentStatusModel statusModel;
        private IAppointmentStatusGUI statusScreen;

        public AppointmentStatusPresenter(IAppointmentStatusGUI statusScreen)
        {
            this.statusScreen = statusScreen;
            statusScreen.Register(this);
            statusModel = new AppointmentStatusModel();
        }
        public void getDetails(int appointmentID)
        {
            statusScreen.setPatientName(statusModel.setName(appointmentID));
            statusScreen.setAppointmentTime(statusModel.setTime(appointmentID));
        }

        public void updateTable(int appointmentID, string value)
        {
            statusModel.updateTable(appointmentID, value);
        }
    }
}
