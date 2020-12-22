using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class ContactedByPhonePresenter
    {
        private IContactedByPhoneModel contactedModel;
        private IContactedByPhoneGUI contactedScreen;

        public ContactedByPhonePresenter(IContactedByPhoneGUI contactedScreen, IContactedByPhoneModel contactedModel)
        {
            this.contactedScreen = contactedScreen;
            contactedScreen.Register(this);
            this.contactedModel = contactedModel;
            initaliseForm();            
        }

        public void initaliseForm()
        {
            contactedScreen.setPatientName(contactedModel.setName(contactedScreen.getAppointmentID()));
            contactedScreen.setAppointmentDate(contactedModel.setDate(contactedScreen.getAppointmentID()));
            contactedScreen.setAppointmentTime(contactedModel.setTime(contactedScreen.getAppointmentID()));
        }

        public void setContacted()
        {
            contactedModel.setToContacted(contactedScreen.getAppointmentID());
        }

    }
}
