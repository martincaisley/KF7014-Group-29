using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class NewAppointmentMVPTest
    {
        NewAppointment form;
        NewAppointmentsModel model;
        NewAppointmentsPresenter presenter = null;

        [TestInitialize]
        public void NewAppointmentMVPTestInitialize()
        {
            form = new NewAppointment(1);
            model = new NewAppointmentsModel();
            presenter = new NewAppointmentsPresenter(form);
        }
        [TestMethod]
        public void TestPresenterFindAppBand1()
        {
            string appType = "Checkup";
            string result = presenter.findAppBand(appType);
            Assert.AreEqual("Band1", result);
        }
    }
}
