using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class NewAppointmentMVPTest
    {
        NewAppointment form;
        NewAppointmentsModel model;
        NewAppointmentsPresenter presenter;
        [TestInitialize]
        public void NewAppointmentMVPTestInitialize()
        {
            form = new NewAppointment(1);
            model = new NewAppointmentsModel();
            presenter = new NewAppointmentsPresenter();
        }
        [TestMethod]
        public void NewAppMVPTest()
        {
            Assert.IsNotNull(form, "Form is null");
            Assert.IsNotNull(model, "model is null");
            Assert.IsNotNull(presenter, "presenter is null");
        }
    }
}
