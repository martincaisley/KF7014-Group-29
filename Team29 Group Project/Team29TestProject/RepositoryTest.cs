using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Team29TestProject
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*var context = new Mock<MyDBEntities>();

            UnitOfWork uow = new UnitOfWork(context.Object);

            Mock<Appointment> app = new Mock<Appointment>();

            app.Object.appointmentID = 1;
            app.Object.appointmentDate = DateTime.Today.Date;

            uow.appointment.Add(app.Object);


            IAppointment appointment = uow.appointment.GetByID(1);

            Assert.AreEqual(DateTime.Today.Date, appointment.appointmentDate);

            */ 

            var testObject = new Appointment();

            var context = new Mock<MyDBEntities>();
            var dbSetMock = new Mock<DbSet<Appointment>>();
            context.Setup(x => x.Set<Appointment>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Add(It.IsAny<Appointment>())).Returns(testObject);

            var repository = new Repository<Appointment>(context.Object);
            repository.Add(testObject);

            context.Verify(x => x.Set<Appointment>());
            dbSetMock.Verify(x => x.Add(It.Is<Appointment>(y => y == testObject)));

        }
    }
}
