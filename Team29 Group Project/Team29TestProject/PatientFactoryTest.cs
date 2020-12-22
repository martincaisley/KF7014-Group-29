using System;
using Team29_Group_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Team29TestProject
{
    [TestClass]
    public class PatientFactoryTest
    {
        [TestMethod]
        public void TestFreePatientFactory()
        {
            PatientFactory factory = new PatientFactory();
            Patient p = factory.GetPatientType(PatientTypes.Free);
            Assert.AreEqual(true, p.isFree);
        }
        [TestMethod]
        public void TestPayedPatientFactory()
        {
            PatientFactory factory = new PatientFactory();
            Patient p = factory.GetPatientType(PatientTypes.Paying);
            Assert.AreEqual(false, p.isFree);
        }
    }
}
