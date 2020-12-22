using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class PatientDetailsViewTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            PatientDetails view = new PatientDetails(1);
            int patientUD = view.getPatientID();
            Assert.AreEqual(1, patientUD);
        }
    }
}
