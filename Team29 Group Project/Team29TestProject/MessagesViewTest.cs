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
