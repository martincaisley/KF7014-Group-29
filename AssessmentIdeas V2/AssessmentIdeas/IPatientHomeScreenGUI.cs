﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AssessmentIdeas
{
    public interface IPatientHomeScreenGUI
    {
        void setDGV(DataTable dt);

        void Register(PatientHomeScreenPresenter PHSP);
    }
}
