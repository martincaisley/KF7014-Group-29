using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class ViewAppointmentsPresenter
    {
        private ViewAppointmentsModel appointmentsModel;
        private IViewAppointmentsGUI appointmentsScreen;
        DateTime date = DateTime.Today;

        public ViewAppointmentsPresenter(IViewAppointmentsGUI appointmentsScreen)
        {
            this.appointmentsScreen = appointmentsScreen;
            appointmentsScreen.Register(this);
            appointmentsModel = new ViewAppointmentsModel();
            showAppointments(date);
        }
        public void showAppointments(DateTime date)
        {
            appointmentsScreen.setDGV(appointmentsModel.getDT(date));
        }
        public void rowSelcted(int index)
        {
            appointmentsScreen.viewChosenAppointment(appointmentsModel.getAppointmentID(index));   
        }
        public void createAppointmentRemindersCSV()
        {
            appointmentsModel.showAppointmentReminders();
        }
    }
}
