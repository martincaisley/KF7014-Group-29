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
    public interface INewAppointmentsGUI
    {
        int getPatientID();
        DateTime getAppointmentDate();
        TimeSpan getAppointmentStartTime();
        TimeSpan getAppointmentEndTime();
        string getAppointmentType();
        void setName(string name);
        void Register(NewAppointmentsPresenter NAP);
        void setAppointmentEndTime(int appointmentLength);
        void setDGV(DataTable DT);
        void setTimePickers();
        string getAppointmentTypeCheckBoxValue();
        void noAppointmentTypeChecked();
        void startTimeAfterEndTime();
        void appDateBeforeToday();
        void appointmentConfirmation();
        void outsideOfWorkingHours();
        void notAnEmergency();
        void appAlreadyAtTime();
    }
}
