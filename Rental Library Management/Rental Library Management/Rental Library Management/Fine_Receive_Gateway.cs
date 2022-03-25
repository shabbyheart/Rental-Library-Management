using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Library_Management
{
    class Fine_Receive_Gateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        List<Book_Receive> LBReceive = null;
        public Fine_Receive_Gateway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }
        public void fine_Recive(Fine_Receive FReceive)
        {
            Fine_Receive newFReceive = new Fine_Receive();
            try
            {
                connection.Open();
                string queryString = "SELECT * FROM Fine_Receive WHERE student_id = '" + FReceive.StudentId + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    newFReceive.Amount = Convert.ToDouble(dataReader["amount"].ToString());
                }
                connection.Close();
            }
            catch (Exception exp)
            {
                //connection.Close();
                // MessageBox.Show(expppp.Message+"second");
                connection.Close();
            }
            FReceive.Amount = newFReceive.Amount - FReceive.Amount;
            if (FReceive.Amount <= 1)
                FReceive.Amount = 0;
            if(FReceive.Amount == 0)
            {
                try
                {
                    // BReceive.Fine = BReceive.Fine + newBReceive.Fine;
                    connection.Open();

                    string queryString = "DELETE FROM  Fine_Receive WHERE student_id = '" + FReceive.StudentId + "' ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.ExecuteNonQuery();
                    //MessageBox.Show("execute");
                    connection.Close();
                }
                catch (Exception expp)
                {
                    MessageBox.Show(expp.Message);
                    connection.Close();
                    return;
                }
            }
            else
            {
                try
                {
                   // BReceive.Fine = BReceive.Fine + newBReceive.Fine;
                    connection.Open();

                    string queryString = "UPDATE  Fine_Receive SET amount = '" + FReceive.Amount + "' WHERE student_id = '" + FReceive.StudentId + "' ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.ExecuteNonQuery();
                    //MessageBox.Show("execute");
                    connection.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    connection.Close();
                    return;
                }
            }
        }

        public List<Fine_Receive> all_Fine_Amount_view(Fine_Receive FReceive)
        {
            List<Fine_Receive> LFReceive = new List<Fine_Receive>();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM Fine_Receive WHERE student_id = '" + FReceive.StudentId + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {


                    Fine_Receive newFReceive = new Fine_Receive();

                    newFReceive.StudentId = Convert.ToInt32(dataReader["student_id"]);
                    newFReceive.Amount = Convert.ToDouble( dataReader["amount"].ToString());

                    LFReceive.Add(newFReceive);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                connection.Close();
            }
            return LFReceive;
        }








        public List<Fine_Receive> all_Student_Fine_Amount_view()
        {
            List<Fine_Receive> LFReceive = new List<Fine_Receive>();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM Fine_Receive ORDER BY student_id ASC ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {


                    Fine_Receive newFReceive = new Fine_Receive();

                    newFReceive.StudentId = Convert.ToInt32(dataReader["student_id"]);
                    newFReceive.Amount = Convert.ToDouble(dataReader["amount"].ToString());

                    LFReceive.Add(newFReceive);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message);
                connection.Close();
            }
            return LFReceive;
        }
    }
}
