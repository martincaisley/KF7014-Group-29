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

           


        }
    }
}
