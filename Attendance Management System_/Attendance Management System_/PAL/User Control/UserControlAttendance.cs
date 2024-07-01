using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System_.PAL.User_Control
{
    public partial class UserControlAttendance : UserControl
    {

        private string sql = @"Data Source = LAPTOP-3G37GPHR\sqlexpress;
                                Initial Catalog = Attendance_Management_System2;
                                Integrated Security = True; Encrypt=False";

        private bool okay;



        public UserControlAttendance()
        {
            InitializeComponent();
            dataGridViewMarkAttendance.Columns["Column1"].Visible = false;
            dataGridViewMarkAttendance.Columns["Column5"].Visible = false;
        }

        private void dataGridViewMarkAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Attendance.Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxClass.SelectedItem.ToString(), sql))
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Table.Student_ID, Student_Name, Student_Reg, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID =Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date == '" + dateTimePickerDate.Text + "' AND Class_Name = '" + comboBoxClass.SelectedItem.ToString() + "';", dataGridViewMarkAttendance, sql);
                okay = true;
            }
            else
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg FROM Student_Table INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID  WHERE Class_Name = '" + comboBoxClass.SelectedItem.ToString() + "';", dataGridViewMarkAttendance, sql);
                okay = false;
            }
        }

        private void tabPageMarkAttendance_Leave(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                string status;
                if (Attendance.Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxClass.SelectedItem.ToString(), sql))
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Present";
                        else
                            status = "Absent";

                        Attendance.Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);


                    }
                }

                else
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Present";
                        else
                            status = "Absent";

                        Attendance.Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);


                    }
                }
            }
        }

        private void dataGridViewMarkAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                if (Attendance.Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxClass.SelectedItem.ToString(), sql) && okay)
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (row.Cells["Column5"].Value.ToString() == "Present")
                            row.Cells["Column4"].Value = true;
                        else
                            row.Cells["Column4"].Value = false;

                    }
                }
            }
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass, sql);

        }

        private void tabPageMarkAttendance_Click(object sender, EventArgs e)
        {

        }
    }
}