using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Team29_Group_Project
{
    public partial class PatientHomeScreen : Form, IPatientHomeScreenGUI
    {
        private PatientHomeScreenPresenter presenter;
        public PatientHomeScreen()
        {
            InitializeComponent();
        }
        private void PatientHomeScreen_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            presenter.processPatients();
        }
        private void btn_viewApps_Click(object sender, EventArgs e)
        {
            ViewAppointments viewAppointments = new ViewAppointments();
            this.Hide();
            viewAppointments.ShowDialog();
            this.Show();
        }

        private void btn_newPatient_Click(object sender, EventArgs e)
        {
            PatientRegistrationGUI addPatient = new PatientRegistrationGUI();
            //AddPatientPresenter app = new AddPatientPresenter(addPatient);
            this.Hide();
            addPatient.ShowDialog();
            this.Show();
        }

        private void dgv_patientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelcted(dgv_patientList.CurrentCell.RowIndex);
        }
        private void dgv_patientList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelcted(dgv_patientList.CurrentCell.RowIndex);
        }
        private void rowSelcted(int index)
        {
            using (var context = new MyDBEntities())
            {
                var patients = context.Patients.ToList();
                int NewPatientID = patients[index].PatientID;
                //PatientDetails patientDetails = new PatientDetails(NewPatientID);
                this.Hide();
                //patientDetails.ShowDialog();
                this.Show();
            }
        }

        public void setDGV(DataTable dt)
        {
            dgv_patientList.DataSource = dt;
            dgv_patientList.AllowUserToAddRows = false;
            dgv_patientList.AllowUserToDeleteRows = false;
            int cols = dgv_patientList.ColumnCount;
            for (int x = 0; x < cols; x++)
            {
                dgv_patientList.Columns[x].ReadOnly = true;
            }
        }

        public void Register(PatientHomeScreenPresenter PHSP)
        {
            presenter = PHSP;
        }
    }
}
