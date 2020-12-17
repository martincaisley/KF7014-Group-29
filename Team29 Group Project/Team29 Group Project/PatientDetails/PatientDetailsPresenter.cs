using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public PatientDetailsPresenter()
        {
        }

        public void showDetails(int patientID)
        {
            bool toRemove = detailsModel.checkRemoved(patientID);
            if (toRemove == true)
            {
                detailsScreen.setLabelToBeRemoved(detailsModel.getName(patientID));
            }
            else
            {
                detailsScreen.setLabel(detailsModel.getName(patientID));
            }            
        }
        public void showPatientDetails(int patientID)
        {
            detailsScreen.setDGV(detailsModel.getDT(patientID));
        }
        public bool getMessages(int patientID)
        {
            bool messages = detailsModel.messagesToView(patientID);
            return messages;
        }
        public void deleteRow(int appointmentID)
        {
            detailsModel.deleteEntry(appointmentID);
        }



    }
}
