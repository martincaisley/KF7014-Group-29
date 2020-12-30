/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
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
            PatientHomeScreenModel phsm = new PatientHomeScreenModel();
            PatientHomeScreenPresenter phsp = new PatientHomeScreenPresenter(phs, phsm);
            Application.Run(phs);
        }
    }
}
