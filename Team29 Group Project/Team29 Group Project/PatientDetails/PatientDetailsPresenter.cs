/*
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
    public class PatientDetailsPresenter
    {
        private IPatientDetailsModel detailsModel;
        private IPatientDetailsGUI detailsScreen;

        public PatientDetailsPresenter(IPatientDetailsGUI detailsScreen, IPatientDetailsModel detailsModel)
        {
            this.detailsScreen = detailsScreen;
            detailsScreen.Register(this);
            this.detailsModel = detailsModel;
            initaliseForm();
        }

        public void initaliseForm()
        {
            showDetails();
            showPatientAppointments();
            longerThanAYear();
            setMessagesToView();
        }

        public void showDetails()
        {
            if (detailsModel.checkRepeatOffences(detailsScreen.getPatientID()) == true)
            {
                detailsScreen.setLabelToBeRemoved(detailsModel.getName(detailsScreen.getPatientID()));
            }
            else
            {
                detailsScreen.setLabel(detailsModel.getName(detailsScreen.getPatientID()));
            }            
        }
        public void showPatientAppointments()
        {
            DataTable dt = detailsModel.getAppointmentList(detailsScreen.getPatientID());
            if (dt.Rows.Count != 0)
            {
                detailsScreen.setDGV(dt);
            }
            else
            {
                detailsScreen.noAppointmentsToShow();
            }
        }
        public void setMessagesToView()
        {
            if (detailsModel.messagesToView(detailsScreen.getPatientID()))
            {
                detailsScreen.messagesButton_show();
            }
            else
            {
                detailsScreen.messagesButton_hide();
            }

        }
        public void deleteRow(int appToDelete)
        {
            detailsModel.deleteEntry(appToDelete);
            showPatientAppointments();
        }
        public void longerThanAYear()
        {
            if (detailsModel.checkQuestionnaireDate(detailsScreen.getPatientID()))
            {
                detailsScreen.setButtonRed();
            }
            else
            {
                detailsScreen.setButtonNormal();
            }
        }

    }
}
