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
