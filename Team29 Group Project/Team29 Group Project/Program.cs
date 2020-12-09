using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team29_Group_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PatientHomeScreen phs = new PatientHomeScreen();
            PatientHomeScreenPresenter phsp = new PatientHomeScreenPresenter(phs);
            Application.Run(phs);

            /*
            using (var context = new MyDBEntities())
            {
                FreePatient p = new FreePatient();
                p.PatientID = 1;
                p.firstName = "Mark";
                p.lastName = "Burns";
                p.DoB = DateTime.Today;
                p.Address = "64 Zoo Lane";
                p.Email = "mark@Email.com";
                p.Occupation = "Student";
                p.PhoneNum = "12345678911";
                p.GPname = "Terry";
                p.GPaddress = "123 Drive Lane";

                context.Patients.Add(p);
                context.SaveChanges();

            }
            
            
            using (var context = new MyDBEntities())
            {
                Appointment a= new Appointment();
                a.appointmentID = 1;
                a.patientID = 1;
                a.appointmentDate = DateTime.Today;
                a.appointmentStartTime = DateTime.Today;
                a.appointmentEndTime = DateTime.Today;
                a.appointmentType = "Checkup";
                a.appointmentLength = 20;
                a.arrivedToAppointment = false;
                a.contacted = false;

                context.Appointments.Add(a);
                context.SaveChanges();

            }
            */
            

        }
    }
}
