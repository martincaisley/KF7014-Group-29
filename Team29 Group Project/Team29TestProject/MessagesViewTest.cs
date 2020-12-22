using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class MessagesViewTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            Messages view = new Messages(1);
            int patientID = view.getPatientID();
            Assert.AreEqual(1, patientID);
        }
    }
}
