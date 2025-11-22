using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmClubRegistration
{
    public partial class Form2 : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            LoadStudentIDs();

            GenderComboBoxUpdate.Items.AddRange(new string[] { "Male", "Female", "Other" });

            ProgramComboBoxUpdate.Items.AddRange(new string[] {
                "BS in Computer Science",
                "BS in Information Technology",
                "BS in Business Administration",
                "BS in Hospitality Management"
            });
        }

        private void LoadStudentIDs()
        {
            DataTable idData = clubRegistrationQuery.GetAllStudentIDs();
            StudentIDComboBoxUpdate.Items.Clear();

            foreach (DataRow row in idData.Rows)
            {
                StudentIDComboBoxUpdate.Items.Add(row["StudentId"].ToString());
            }
        }

        private void StudentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentIDComboBoxUpdate.SelectedItem != null)
            {
                long selectedStudentId = long.Parse(StudentIDComboBoxUpdate.SelectedItem.ToString());
                DataTable studentData = clubRegistrationQuery.GetStudentByID(selectedStudentId);

                if (studentData.Rows.Count > 0)
                {
                    DataRow row = studentData.Rows[0];
                    FirstNameTxtbxUpdate.Text = row["FirstName"].ToString();
                    MiddleNameTxtbxUpdate.Text = row["MiddleName"].ToString();
                    LastNameTxtbxUpdate.Text = row["LastName"].ToString();
                    AgeTxtbxUpdate.Text = row["Age"].ToString();
                    GenderComboBoxUpdate.Text = row["Gender"].ToString();
                    ProgramComboBoxUpdate.Text = row["Program"].ToString();
                }
            }
        }

        private void UpdateFormBtn_Click(object sender, EventArgs e)
        {
            if (StudentIDComboBoxUpdate.SelectedItem == null)
            {
                MessageBox.Show("Please select a Student ID first.");
                return;
            }

            if (string.IsNullOrEmpty(FirstNameTxtbxUpdate.Text) ||
                string.IsNullOrEmpty(LastNameTxtbxUpdate.Text) ||
                string.IsNullOrEmpty(AgeTxtbxUpdate.Text) ||
                GenderComboBoxUpdate.SelectedItem == null ||
                ProgramComboBoxUpdate.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            long studentId = long.Parse(StudentIDComboBoxUpdate.SelectedItem.ToString());
            string firstName = FirstNameTxtbxUpdate.Text;
            string middleName = MiddleNameTxtbxUpdate.Text;
            string lastName = LastNameTxtbxUpdate.Text;
            int age = int.Parse(AgeTxtbxUpdate.Text);
            string gender = GenderComboBoxUpdate.SelectedItem.ToString();
            string program = ProgramComboBoxUpdate.SelectedItem.ToString();

            clubRegistrationQuery.UpdateStudent(studentId, firstName, middleName, lastName, age, gender, program);

            MessageBox.Show("Student information updated successfully!");
            this.Close();
        }

        private void StudentIdTxtbxUpdate_TextChanged(object sender, EventArgs e) { }
        private void LastNameTxtbxUpdate_TextChanged(object sender, EventArgs e) { }
        private void FirstNameTxtbxUpdate_TextChanged(object sender, EventArgs e) { }
        private void MiddleNameTxtbxUpdate_TextChanged(object sender, EventArgs e) { }
        private void AgeTxtbxUpdate_TextChanged(object sender, EventArgs e) { }
        private void GenderComboBoxUpdate_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ProgramComboBoxUpdate_SelectedIndexChanged(object sender, EventArgs e) { }

        private void StudentIDComboBoxUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}