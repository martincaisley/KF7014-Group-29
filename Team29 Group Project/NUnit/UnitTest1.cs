using NUnit.Framework;
using Moq;
using NUnit;

namespace NUnit
{
    public class Tests
    {
        Mock<NewAppointment> form;
        Mock<NewAppointmentsModel> model;
        NewAppointmentsPresenter presenter;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            [TestMethod]
            public void TestPresenter()
            {

                form = new Mock<NewAppointment>(1);
                model = new Mock<NewAppointmentsModel>();
                presenter = new NewAppointmentsPresenter(form.Object);

                string appType = "Checkup";
                string result = presenter.findAppBand(appType);
                Assert.AreEqual("Band1", result);
            }
        }
    }

}
    }
}