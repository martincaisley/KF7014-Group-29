﻿/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
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
        private void btn_viewApps_Click(object sender, EventArgs e)
        {
            ViewAppointments viewAppointments = new ViewAppointments();
            ViewAppointmentsModel viewAppointmentsModel = new ViewAppointmentsModel();
            ViewAppointmentsPresenter VAP = new ViewAppointmentsPresenter(viewAppointments, viewAppointmentsModel);
            this.Hide();
            viewAppointments.ShowDialog();
            this.Show();
        }

        private void btn_newPatient_Click(object sender, EventArgs e)
        {
            PatientRegistrationGUI addPatient = new PatientRegistrationGUI();
            PatientRegistrationModel registrationModel = new PatientRegistrationModel();
            PatientRegistrationPresenter PRP = new PatientRegistrationPresenter(addPatient, registrationModel);
            this.Hide();
            addPatient.ShowDialog();
            presenter.processPatientsList();
            this.Show();
        }

        private void dgv_patientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.rowSelcted(Convert.ToInt32(dgv_patientList.CurrentRow.Cells[0].Value.ToString()));
        }
        private void dgv_patientList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.rowSelcted(Convert.ToInt32(dgv_patientList.CurrentRow.Cells[0].Value.ToString()));
        }
        
        public void viewPatient(int patientID)
        {
            PatientDetails patientDetails = new PatientDetails(patientID);
            PatientDetailsModel patientDetailsModel = new PatientDetailsModel();
            PatientDetailsPresenter PDP = new PatientDetailsPresenter(patientDetails,patientDetailsModel);
            this.Hide();
            patientDetails.ShowDialog();
            presenter.processPatientsList();
            this.Show();
        }
        

        public void setDGV(DataTable dt)
        {
            dgv_patientList.Show();
            lbl_active.Text = "Active Patients";
            dgv_patientList.DataSource = dt;
            dgv_patientList.AllowUserToAddRows = false;
            dgv_patientList.AllowUserToDeleteRows = false;
            int cols = dgv_patientList.ColumnCount;
            for (int x = 0; x < cols; x++)
            {
                dgv_patientList.Columns[x].ReadOnly = true;
            }
        }

        public void noPatientsToShow()
        {
            dgv_patientList.Hide();
            lbl_active.Text = "No Patients Added";
        }

        public void Register(PatientHomeScreenPresenter PHSP)
        {
            presenter = PHSP;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selection = MessageBox.Show("Are you sure you want to delete this patient?", "Confirmation", MessageBoxButtons.YesNo);
            if (selection == DialogResult.Yes)
            {
                presenter.deleteRow((int)dgv_patientList.SelectedCells[0].OwningRow.Cells[0].Value);                
            }
        }
    }
}
