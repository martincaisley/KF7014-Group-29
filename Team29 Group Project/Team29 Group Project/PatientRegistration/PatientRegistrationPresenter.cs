using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class PatientRegistrationPresenter
    {
        private IPatientRegistrationModel model;
        private IPatientRegistrationGUI form;

        public PatientRegistrationPresenter(IPatientRegistrationGUI form, IPatientRegistrationModel model)
        {
            this.form = form;
            form.Register(this);
            this.model = model;
            
        }

        public int getLastPatientID()
        {
            return model.getLastPatientID();
        }
        public void ProcessNewPatient()
        { 
            String firstName = form.GetFirstname().Trim();
            String surname = form.GetSurname().Trim();
            DateTime DoB = form.GetDoB();
            String address = form.GetAddress().Trim();
            String email = form.GetEmail().Trim();
            String phoneNum = form.GetPhoneNumber().Trim();
            String occupation = form.GetOccupation().Trim();
            String GPname = form.GetGPname().Trim();
            String GPaddress = form.GetGPaddress().Trim();
            
            string type;
            if (form.GetPaymentType())
            {
                type = "Free";
            }
            else 
            {
                type = "Paying"; 
            }
            model.AddPatient(firstName, surname, DoB, address, email, phoneNum, occupation, GPname, GPaddress,type);

         


        }

    }
}
