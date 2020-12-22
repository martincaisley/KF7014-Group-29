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
    public partial class ViewAppointments : Form, IViewAppointmentsGUI
    {
        private ViewAppointmentsPresenter presenter;
        public ViewAppointments()
        {
            InitializeComponent();
        }
        private void ViewAppointments_Load(object sender, EventArgs e)
        {

        }

        public void setDGV(DataTable dt)
        {
            dgv_appointmentList.Show();
            lbl_today.Text = "Appointments For";
            dgv_appointmentList.DataSource = dt;
            dgv_appointmentList.AllowUserToAddRows = false;
            dgv_appointmentList.AllowUserToDeleteRows = false;
            int cols = dgv_appointmentList.ColumnCount;
            for (int x = 0; x < cols; x++)
            {
                dgv_appointmentList.Columns[x].ReadOnly = true;
            }
        }
        public void noAppointmentsToShow()
        {
            dgv_appointmentList.Hide();
            lbl_today.Text = "No appointments";
        }
        private void btn_phoneReminders_Click(object sender, EventArgs e)
        {
            PhoneReminders phoneReminders = new PhoneReminders();
            PhoneRemindersModel remindersModel = new PhoneRemindersModel();  
            PhoneRemindersPresenter PRP = new PhoneRemindersPresenter(phoneReminders, remindersModel);
            this.Hide();
            phoneReminders.ShowDialog();
            this.Show();
        }

        private void dgv_appointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.rowSelcted(Convert.ToInt32(dgv_appointmentList.CurrentRow.Cells[6].Value.ToString()));
        }
        private void dgv_appointmentList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.rowSelcted(Convert.ToInt32(dgv_appointmentList.CurrentRow.Cells[6].Value.ToString()));
        }

        public void viewChosenAppointment(int appointmentID)
        {
            AppointmentStatus appointmentStatus = new AppointmentStatus(appointmentID);
            AppointmentStatusModel appointmentStatusModel = new AppointmentStatusModel();
            AppointmentStatusPresenter ASP = new AppointmentStatusPresenter(appointmentStatus, appointmentStatusModel);
            this.Hide();
            appointmentStatus.ShowDialog();
            presenter.showAppointments(dtp_appointmentDate.Value.Date);
            this.Show();
        }

        private void btn_textReminders_Click(object sender, EventArgs e)
        {
            presenter.createAppointmentRemindersCSV();
            MessageBox.Show("Reminders File Created");
        }
        public void Register(ViewAppointmentsPresenter VAP)
        {
            presenter = VAP;
        }

        private void dtp_appointmentDate_ValueChanged(object sender, EventArgs e)
        {
            presenter.showAppointments(dtp_appointmentDate.Value.Date);
        }

        
    }
}
