﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System_.PAL.Forms
{
    public partial class FormMain : Form
    {
        public string Username, Role;

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();    
              }
            else
                panelExpand.Hide();
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if (Role == "User")
            { 
                buttonDashboard.Hide();
                buttonAddclass.Hide();
                buttonAddStudent.Hide();
                buttonRegister.Hide();
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;

        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now =DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
        }


        private void buttonAttendance_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
                {
                    MoveSidePanel(buttonReport);
                    userControlAddClass1.Visible = false;
                    userControlDashboard1.Visible = false;
                }

        private void buttonAddclass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddclass);
            userControlAddClass1.ClearTextBox();
            userControlAddClass1.Visible = true;
            userControlDashboard1.Visible = false;
        }


        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
        }

        


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if(panelExpand.Visible)
                panelExpand.Visible = false;
            else
                panelExpand.Visible = true;
        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void panelExpand_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        

        
    }
}
