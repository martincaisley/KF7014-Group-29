﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentIdeas
{
    public class PatientHomeScreenPresenter
    {
        private PatientHomeScreenModel patientModel;
        private IPatientHomeScreenGUI patientScreen;

        public PatientHomeScreenPresenter(IPatientHomeScreenGUI patientScreen)
        {
            this.patientScreen = patientScreen;
            patientScreen.Register(this);
            patientModel = new PatientHomeScreenModel();
            initialiseForm();
        }
        private void initialiseForm()
        {
            processPatients();
        }
        public void processPatients()
        {
            patientScreen.setDGV(patientModel.getDT());
        }

    }
}
