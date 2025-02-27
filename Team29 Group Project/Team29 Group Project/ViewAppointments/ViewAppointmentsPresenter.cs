﻿/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
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
        private IViewAppointmentsModel appointmentsModel;
        private IViewAppointmentsGUI appointmentsScreen;
        DateTime date = DateTime.Today;

        public ViewAppointmentsPresenter(IViewAppointmentsGUI appointmentsScreen, IViewAppointmentsModel appointmentsModel)
        {
            this.appointmentsScreen = appointmentsScreen;
            appointmentsScreen.Register(this);
            this.appointmentsModel = appointmentsModel;
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
