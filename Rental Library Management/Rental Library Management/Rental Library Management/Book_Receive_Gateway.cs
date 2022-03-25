using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Library_Management
{
    
    class Book_Receive_Gateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        List<Book_Receive> LBReceive = null;
        public Book_Receive_Gateway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }
        Book_Receive newBReceive = new Book_Receive();
        public void fine_amount_entry(Book_Receive BReceive)
        {
            try
            {
                connection.Open();
                //MessageBox.Show(BIssue.StudentId.ToString() + BIssue.BookId);
                string queryString = "INSERT INTO Fine_Receive values('" + BReceive.StudentId + "','" + BReceive.Fine + "' )";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exp)
            {
               // MessageBox.Show(exp.Message+"first");
                connection.Close();
                try
                {
                    connection.Open();

                    string queryString = "SELECT * FROM Fine_Receive WHERE student_id = '" + BReceive.StudentId + "' ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    
                    while (dataReader.Read())
                    { 
                        newBReceive.Fine = Convert.ToDouble(dataReader["amount"].ToString());
                    }

                    connection.Close();
                }
                catch (Exception expppp)
                {
                    //connection.Close();
                   // MessageBox.Show(expppp.Message+"second");
                    connection.Close();
                }

                try
                {
                    BReceive.Fine = BReceive.Fine + newBReceive.Fine;
                    connection.Open();
                    
                    string queryString = "UPDATE  Fine_Receive SET amount = '"+ BReceive.Fine + "' WHERE student_id = '" + BReceive.StudentId + "' ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.ExecuteNonQuery();
                    //MessageBox.Show("execute");
                    connection.Close();
                }
                catch (Exception expp)
                {
                    //MessageBox.Show(expp.Message+"3RD");
                    connection.Close();
                    //connection.Close();
                    return;
                }
            }
            //MessageBox.Show("Successfully Insert!");
        }
        public void book_Receive(Book_Receive BReceive)
        {
            try
            {
                connection.Open();
                string deleteString = " DELETE FROM Book_Issue WHERE book_id = '" + BReceive.BookId + "' and student_id = '"+ BReceive.StudentId+"' ";

                SqlCommand command = new SqlCommand(deleteString, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully Receive!!");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
                connection.Close();
                return;
            }
        }
        public List<Book_Receive> student_Status_view(Book_Receive BReceive)
        {
            LBReceive = new List<Book_Receive>();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM Book_Issue WHERE student_id = '" + BReceive.StudentId + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {


                    Book_Receive newBReceive = new Book_Receive();

                    newBReceive.StudentId = Convert.ToInt32(dataReader["student_id"]);
                    newBReceive.StudentName = dataReader["sutdent_name"].ToString();
                    newBReceive.Department = dataReader["department"].ToString();
                    newBReceive.BookId = Convert.ToInt32(dataReader["book_id"]);
                    newBReceive.BookName = dataReader["book_name"].ToString();
                    newBReceive.Author = dataReader["author"].ToString();
                    newBReceive.Publisher = dataReader["publisher"].ToString();
                    newBReceive.IssueDate = dataReader["issue_date"].ToString();
                    //we need to create a list of department
                    LBReceive.Add(newBReceive);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message);
                connection.Close();
            }
            return LBReceive;
        }




        public List<Book_Receive> GrideviewData( Book_Receive BReceive)
        {
            List<Book_Receive> LBReceive = new List<Book_Receive>();
            Book_Receive newBReceive = new Book_Receive();
            
            try
            {
                connection.Open();
                string insertString = "SELECT * FROM Book_Issue WHERE student_id = '" + BReceive.StudentId + "' ";
                SqlCommand command = new SqlCommand(insertString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                //while (dataReader.Read())
                //{
                    MessageBox.Show(dataReader["sutdent_name"].ToString());
                    newBReceive.StudentName = dataReader["sutdent_name"].ToString();
                    newBReceive.Department = dataReader[" department"].ToString();
                    newBReceive.BookId = Convert.ToInt32( dataReader["book_id"]);
                    newBReceive.BookName = dataReader["book_name"].ToString();
                    newBReceive.Author = dataReader["author"].ToString();
                    newBReceive.Publisher = dataReader[" publisher"].ToString();
                    newBReceive.IssueDate = dataReader["issue_date"].ToString();

                //}
                //newBIssue.StudentName = dataReader["first_name"].ToString() + " " + dataReader["last_name"].ToString();
                //newBIssue.Department1 = dataReader["depertment"].ToString();

                connection.Close();
            }
            catch (Exception exp)
            {
                //newBIssue.StudentId = -1;
                MessageBox.Show("why you here");
                connection.Close();

            }
            
            return LBReceive;
        }
    }
}
