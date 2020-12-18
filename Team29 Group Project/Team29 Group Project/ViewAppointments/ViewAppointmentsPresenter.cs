using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            DataTable dt = appointmentsModel.getAppointmentsList(date);
            if (dt.Rows.Count != 0)
            {
                appointmentsScreen.setDGV(dt);
            }
            else
            {
                appointmentsScreen.noAppointmentsToShow();
            }
        }
        public void rowSelcted(int appointmentID)
        {
            appointmentsScreen.viewChosenAppointment(appointmentID);   
        }
        public void createAppointmentRemindersCSV()
        {
            appointmentsModel.generateCSVFile();
        }
    }
}
