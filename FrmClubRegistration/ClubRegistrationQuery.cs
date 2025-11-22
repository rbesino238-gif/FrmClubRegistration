using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrmClubRegistration
{
    public class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;
        public long _StudentId;

        public ClubRegistrationQuery()
        {
     
            connectionString = @"Data Source=LAPTOP-VBK2CP8T\SQLEXPRESS01;Initial Catalog=ClubDB_Russel;";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);
            dataTable.Clear();
            bindingSource.DataSource = dataTable;
            return true;
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;


            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        public bool UpdateStudent(long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("UPDATE ClubMembers SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Age=@Age, Gender=@Gender, Program=@Program WHERE StudentId=@StudentID", sqlConnect);
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        public DataTable GetStudentByID(long StudentID)
        {
            DataTable studentData = new DataTable();
            string query = "SELECT * FROM ClubMembers WHERE StudentId = @StudentID";
            sqlCommand = new SqlCommand(query, sqlConnect);
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;

            sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(studentData);
            return studentData;
        }

        public DataTable GetAllStudentIDs()
        {
            DataTable idData = new DataTable();
            string query = "SELECT StudentId FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(query, sqlConnect);
            return idData;
        }
    }
}