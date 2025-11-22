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
    public partial class Form1 : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();

            GenderCombobox.Items.AddRange(new string[] { "Male", "Female", "Other" });

            ProgramCombobox.Items.AddRange(new string[] {
                "BS in Computer Science",
                "BS in Information Technology",
                "BS in Business Administration",
                "BS in Hospitality Management"
            });
        }

        private void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            ListOfClubMembersview.DataSource = clubRegistrationQuery.bindingSource;
        }

        private int RegistrationID()
        {
            count++;
            return count;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StudentIdTxtbx.Text) ||
                string.IsNullOrEmpty(LastNameTxtbx.Text) ||
                string.IsNullOrEmpty(FirstNameTxtbx.Text) ||
                string.IsNullOrEmpty(aGETxtbx.Text) ||
                GenderCombobox.SelectedItem == null ||
                ProgramCombobox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            ID = RegistrationID();
            StudentId = long.Parse(StudentIdTxtbx.Text);
            FirstName = FirstNameTxtbx.Text;
            MiddleName = MiddleNameTxtbx.Text;
            LastName = LastNameTxtbx.Text;
            Age = int.Parse(aGETxtbx.Text);
            Gender = GenderCombobox.SelectedItem.ToString();
            Program = ProgramCombobox.SelectedItem.ToString();

            clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);

            MessageBox.Show("Student registered successfully!");
            ClearForm();
            RefreshListOfClubMembers();
        }

        private void ClearForm()
        {
            StudentIdTxtbx.Clear();
            LastNameTxtbx.Clear();
            FirstNameTxtbx.Clear();
            MiddleNameTxtbx.Clear();
            aGETxtbx.Clear();
            GenderCombobox.SelectedIndex = -1;
            ProgramCombobox.SelectedIndex = -1;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Form2 updateForm = new Form2();
            updateForm.ShowDialog();
            RefreshListOfClubMembers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void StudentIdTxtbx_TextChanged(object sender, EventArgs e) { }
        private void ProgramCombobox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LastNameTxtbx_TextChanged(object sender, EventArgs e) { }
        private void FirstNameTxtbx_TextChanged(object sender, EventArgs e) { }
        private void MiddleNameTxtbx_TextChanged(object sender, EventArgs e) { }
        private void aGETxtbx_TextChanged(object sender, EventArgs e) { }
        private void GenderCombobox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ListOfClubMembersview_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}