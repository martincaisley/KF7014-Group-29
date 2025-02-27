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

namespace Team29_Group_Project
{
    public class NewAppointmentsPresenter
    {
        #region Instance Variables
        private INewAppointmentsModel newAppointmentsModel;
        private INewAppointmentsGUI NewAppointmentsScreen;
        int appLength;
        DateTime Date = DateTime.Today;

        #endregion

        #region Constructor

        public NewAppointmentsPresenter(INewAppointmentsGUI NewAppointmentsScreen, INewAppointmentsModel model)
        {
            this.NewAppointmentsScreen = NewAppointmentsScreen;
            NewAppointmentsScreen.Register(this);
            newAppointmentsModel = model;
            initialiseForm();
        }

        #endregion

        #region Form Initialiser

        public void initialiseForm()
        {
            NewAppointmentsScreen.setTimePickers();
            showAppointmentList(Date);
            getPatientName();
        }
        #endregion

        #region Process Appointment
        public void processAppointment()
        {
            int patientID = NewAppointmentsScreen.getPatientID();
            DateTime appointmentDate = NewAppointmentsScreen.getAppointmentDate();
            TimeSpan appointmentStartTime = NewAppointmentsScreen.getAppointmentStartTime();
            TimeSpan appointmentEndTime = NewAppointmentsScreen.getAppointmentEndTime();
            int appointmentLength = appLength;
            string appointmentType = NewAppointmentsScreen.getAppointmentType();
            string appointmentBand = findAppBand(appointmentType);

            if (appointmentRadioChecked(appointmentType) && appDateBeforeToday(appointmentDate) && endTimeBeforeStartTime(appointmentStartTime,appointmentEndTime) 
                && checkEmergency(appointmentDate,appointmentStartTime,appointmentEndTime) 
                && checkInWorkingHours(appointmentStartTime, appointmentEndTime) && checkTime(appointmentDate, appointmentStartTime, appointmentEndTime))
            {
                newAppointmentsModel.AddAppointmentToDatabase(patientID, appointmentDate, appointmentStartTime, appointmentEndTime, appointmentLength, appointmentType, appointmentBand);
                NewAppointmentsScreen.appointmentConfirmation();
            }
        }
        #endregion

        #region Find Appointment Band for Cost
        public string findAppBand(string appType)
        {
            string appBand = "";

            if (appType == "Checkup" || appType == "ScaleAndPolish")
            {
                appBand = "Band1";
            }
            else if (appType == "BrokenTooth" || appType == "RootCanal" || appType == "Filings" 
                || appType == "Crowns" || appType == "Bridges" || appType == "DentalImplants" || appType == "WisdowmTooth" || appType == "Braces")
            {
                appBand = "Band2";
            }
            else
            {
                appBand = "Band3";
            }


            return appBand;
        }
        #endregion

        #region Get Patient Name
        public void getPatientName()
        {
            NewAppointmentsScreen.setName(newAppointmentsModel.GetPatientName(NewAppointmentsScreen.getPatientID()));
        }
        #endregion

        #region Set Appointment Type
        public void setAppLength(string appType)
        {
            string appointmentType = appType;
            appLength = newAppointmentsModel.getAppointmentLength(appointmentType);
            NewAppointmentsScreen.setAppointmentEndTime(appLength);
        }
        #endregion

        #region Show Appointment List
        public void showAppointmentList(DateTime AppDate)
        {
            NewAppointmentsScreen.setDGV(newAppointmentsModel.getAppointmentsDT(AppDate));
        }
        #endregion

        #region validation for view
        public bool appointmentRadioChecked(string appType)
        {
            if (appType == "")
            {
                NewAppointmentsScreen.noAppointmentTypeChecked();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool appDateBeforeToday(DateTime date)
        {
            if (date < DateTime.Today.Date)
            {
                NewAppointmentsScreen.appDateBeforeToday();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool endTimeBeforeStartTime(TimeSpan startTime, TimeSpan endTime)
        {
            if (endTime <= startTime)
            {
                NewAppointmentsScreen.startTimeAfterEndTime();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Checking Restricted Appointment times
        //ensures that there are no appointments alredy during these times
        public bool checkTime(DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            bool noAppointmentAtThisTime = newAppointmentsModel.checkIfCanBookAtThisTime(date, startTime, endTime);
            
            if(noAppointmentAtThisTime == true)
            {
                return true;
            }
            else
            {
                NewAppointmentsScreen.appAlreadyAtTime();
                return false;
            }
        }

        //Ensures the appointment is between working hours of 9-5
        public bool checkInWorkingHours(TimeSpan startTime, TimeSpan endTime)
        {
            TimeSpan workStartTime = TimeSpan.Parse("09:00:00");
            TimeSpan workEndTime = TimeSpan.Parse("17:00:00");
            if (startTime < workStartTime || startTime > workEndTime || endTime < workStartTime || endTime > workEndTime)
            {
                NewAppointmentsScreen.outsideOfWorkingHours();
                return false;
            }
            else
            {
                return true;
            }
        }
        //11-13 everyday reserved for emergencies, cannot book in advance for this time
        public bool checkEmergency(DateTime dateInputted, TimeSpan startTime, TimeSpan endTime)
        {
            TimeSpan startingHour = TimeSpan.Parse("11:00:00");
            TimeSpan endingHour = TimeSpan.Parse("13:00:00");
            if (dateInputted != DateTime.Today.Date)
            {
                if ((startTime < startingHour && endTime > startingHour) || (startTime > startingHour && endTime < endingHour) || (startTime < endingHour && endTime > endingHour))
                {
                    NewAppointmentsScreen.notAnEmergency();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        #endregion


    }
}

