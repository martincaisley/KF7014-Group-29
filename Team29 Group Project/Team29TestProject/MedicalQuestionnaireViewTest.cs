/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class MedicalQuestionnaireViewTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            MedicalQuestionnaireGUI view = new MedicalQuestionnaireGUI(1);
            int patientID = view.GetPatientID();
            Assert.AreEqual(1, patientID);
        }
    }
}
