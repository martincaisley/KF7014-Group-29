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
        private PatientDetailsModel detailsModel;
        private IPatientDetailsGUI detailsScreen;

        public PatientDetailsPresenter(IPatientDetailsGUI detailsScreen)
        {
            this.detailsScreen = detailsScreen;
            detailsScreen.Register(this);
            detailsModel = new PatientDetailsModel();
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

        public void ShowMedicalQuestionnaire()
        {
            MedicalQuestionnaireGUI med = new MedicalQuestionnaireGUI(detailsScreen.getPatientID());
            MedicalQuestionnairePresenter MQP = new MedicalQuestionnairePresenter(med);
            med.Show();
        }

        public void longerThanAYear()
        {
            if (detailsModel.checkQuestionnaireDate(detailsScreen.getPatientID()))
            {
                detailsScreen.setButtonRed();
            }
        }

    }
}
