using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Library_Management
{
    class Login
    {

        DBConnector connector = null;
        SqlConnection connection = null;
        public Login()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }
        public User student_Id_And_Password_Check(User user)
        {
            User newUser = new User();
            try
            {
                connection.Open();

                string queryString = "SELECT student_id,password FROM Student_Registration WHERE student_id = '" + user.Username + "'";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                newUser.Username = dataReader["student_id"].ToString();
                newUser.Password = dataReader["password"].ToString();

                
                connection.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show("StudentId Wrong");
            }
            return newUser;
        }
        public User UserNameAndPasswordCheck(User user)
        {
            User newUser = new User();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM LogInTable WHERE username = '"+user.Username+"'";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                newUser.Username = dataReader["username"].ToString();
                newUser.Password = dataReader["password"].ToString();

                connection.Close();
                
            }
            catch(Exception exp)
            {
                MessageBox.Show("UserName Wrong");
            }
            return newUser;
        }
    }
}
