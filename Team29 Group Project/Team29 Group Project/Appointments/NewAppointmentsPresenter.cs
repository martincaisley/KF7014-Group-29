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
        DateTime Date = DateTime.Today;

        public NewAppointmentsPresenter(INewAppointmentsGUI NewAppointmentsScreen)
        {
            this.NewAppointmentsScreen = NewAppointmentsScreen;
            NewAppointmentsScreen.Register(this);
            newAppointmentsModel = new NewAppointmentsModel();
            showAppointmentList(Date);
            
        }

        public NewAppointmentsPresenter()
        {
        }

        public void processAppointment()
        {
            int patientID = NewAppointmentsScreen.getPatientID();
            DateTime appointmentDate = NewAppointmentsScreen.getAppointmentDate();
            TimeSpan appointmentStartTime = NewAppointmentsScreen.getAppointmentStartTime();
            TimeSpan appointmentEndTime = NewAppointmentsScreen.getAppointmentEndTime();
            int appointmentLength = appLength;
            string appointmentType = NewAppointmentsScreen.getAppointmentType();

            string appointmentBand = findAppBand(appointmentType);

            newAppointmentsModel.WriteToDatabase(patientID, appointmentDate, appointmentStartTime, appointmentEndTime, appointmentLength, appointmentType, appointmentBand);
        }

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

        public void showAppointmentList(DateTime AppDate)
        {
            NewAppointmentsScreen.setDGV(newAppointmentsModel.getDT(AppDate));
        }

        public bool checkTime(DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            return newAppointmentsModel.checkTime(date, startTime, endTime);
        }
        public bool checkEmergency(DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            if (date != DateTime.Today.Date)
            {
                TimeSpan startingHour = TimeSpan.Parse("11:00:00");
                TimeSpan endingHour = TimeSpan.Parse("13:00:00");
                if ((startTime < startingHour && endTime > startingHour) || (startTime > startingHour && endTime < endingHour) || (startTime < endingHour && endTime > endingHour))
                {
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


    }
}

