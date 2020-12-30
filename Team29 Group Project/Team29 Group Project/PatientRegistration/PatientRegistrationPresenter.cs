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

        private bool ValidData()
        {
            if (IsFirstNameOnlyLetters(form.GetFirstname()) && IsSurnameOnlyLetters(form.GetSurname()) && IsPhoneNumberOnlyNumbers(form.GetPhoneNumber()) && IsGPNameText(form.GetGPname()))
            {
                
                form.SetMessage("Patient has been added!");
                form.Message();
                return true;
            }
            else
            {
                form.SetMessage("Form data is not valid please try again!");
                form.Message();
                return false;
            }


        }
        public bool IsFirstNameOnlyLetters(string input)
        {
            if (input.All(Char.IsLetter))
            {
                
                return true;

            }
            
            else
            {
                return false;
            }

           
        }
        public bool IsSurnameOnlyLetters(string input)
        {
            if (input.All(Char.IsLetter))
            {

                return true;

            }

            else
            {
                return false;
            }
        }
       
        public bool IsPhoneNumberOnlyNumbers(string input)
        {
            if (input.All(Char.IsNumber))
            {

                return true;

            }

            else
            {
                return false;
            }
        }
        public bool IsGPNameText(string input)
        {
            string inputTrimmed = input.Replace(" ", string.Empty);
            if (inputTrimmed.All(Char.IsLetter))
            {

                return true;

            }

            else
            {
                return false;
            }
        }
        public void ProcessNewPatient()
        {
            if (ValidData())
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
                model.AddPatient(firstName, surname, DoB, address, email, phoneNum, occupation, GPname, GPaddress, type);
                form.OpenDetails();


            }




        }

    }
}
