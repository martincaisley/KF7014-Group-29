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

namespace Team29_Group_Project
{
    public partial class PatientDetails : Form, IPatientDetailsGUI
    {
        int patientID;
        private PatientDetailsPresenter presenter;
        public PatientDetails(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }
        private void PatientDetails_Load(object sender, EventArgs e)
        {
        }

        public int getPatientID()
        {
            return patientID;
        }

        public void setButtonRed()
        {
            BTN_medicalQuestionnaire.BackColor = System.Drawing.Color.Red;
        }

        public void setButtonNormal() 
        {
            BTN_medicalQuestionnaire.BackColor = default;
        }

        public void setLabel(string patientName)
        {
            lbl_name.Text = patientName;
            lbl_name.ForeColor = System.Drawing.Color.Black;
        }

        public void setLabelToBeRemoved(string patientName)
        {
            lbl_name.Text = patientName + " - To be removed";
            lbl_name.ForeColor = System.Drawing.Color.Red;
        }

        public void setDGV(DataTable dt)
        {
            dgv_patientAppointments.Show();
            lbl_noAppointments.Text = "";
            dgv_patientAppointments.DataSource = dt;
            dgv_patientAppointments.AllowUserToAddRows = false;
            dgv_patientAppointments.AllowUserToDeleteRows = false;
            int cols = dgv_patientAppointments.ColumnCount;
            for (int x = 0; x < cols; x++)
            {
                dgv_patientAppointments.Columns[x].ReadOnly = true;
            }
        }
        public void noAppointmentsToShow()
        {
            dgv_patientAppointments.Hide();
            lbl_noAppointments.Text = "No Appointments";
        }

        public void messagesButton_hide()
        {
            btn_messages.Hide();
        }

        public void messagesButton_show()
        {
            btn_messages.Show();
        }

        private void btn_newAppointment_Click(object sender, EventArgs e)
        {
            NewAppointment newAppointment = new NewAppointment(patientID);
            NewAppointmentsModel model = new NewAppointmentsModel();
            NewAppointmentsPresenter NAP = new NewAppointmentsPresenter(newAppointment, model);
            this.Hide();
            newAppointment.ShowDialog();
            presenter.showPatientAppointments();
            this.Show();
        }

        private void btn_messages_Click_1(object sender, EventArgs e)
        {
            Messages messages = new Messages(patientID);
            MessagesModel messagesModel = new MessagesModel();
            MessagesPresenter MP = new MessagesPresenter(messages, messagesModel);
            this.Hide();
            messages.ShowDialog();
            presenter.initaliseForm();
            this.Show();
        }

        public void Register(PatientDetailsPresenter PDP)
        {
            presenter = PDP;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selection = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo);
            if (selection == DialogResult.Yes)
            {
                try
                {
                    presenter.deleteRow((int)dgv_patientAppointments.SelectedCells[0].OwningRow.Cells[3].Value);
                }
                catch (Exception f)
                {
                    Console.WriteLine("No row selected " + f.Message);
                }
            }

        }

        private void BTN_medicalQuestionnaire_Click(object sender, EventArgs e)
        {
            MedicalQuestionnaireGUI med = new MedicalQuestionnaireGUI(patientID);
            MedicalQuestionnaireModel medmod = new MedicalQuestionnaireModel();
            MedicalQuestionnairePresenter MQP = new MedicalQuestionnairePresenter(med,medmod);
            this.Hide();
            med.ShowDialog();
            presenter.initaliseForm();
            this.Show();

        }
    }
}
