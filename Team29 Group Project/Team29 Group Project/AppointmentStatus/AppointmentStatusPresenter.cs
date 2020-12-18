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
            initialiseForm();
        }
        public void initialiseForm()
        {
            statusScreen.setPatientName(statusModel.setName(statusScreen.getAppointmentID()));
            statusScreen.setAppointmentTime(statusModel.setTime(statusScreen.getAppointmentID()));
            statusScreen.setAppointmentCost(statusModel.setCost(statusScreen.getAppointmentID()));
        }

        public void updateTable()
        {
            statusModel.updateTable(statusScreen.getAppointmentID(), statusScreen.getAppointmentStatus());
        }
    }
}
