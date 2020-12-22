using NUnit.Framework;

namespace NUnitTesting
{
    public class Tests
    {

        Mock NewAppointment;
        NewAppointmentsPresenter presenter;

        [SetUp]
        public void Setup()
        {
            NewAppointment = new Mock();
            presenter = new NewAppointmentsPresenter();
        }

        [Test]
        public void Test1()
        {
            string appType = "Checkup";
            string result = presenter.findAppBand(appType);
            Assert.AreEqual("Band1", result);
        }
    }
}