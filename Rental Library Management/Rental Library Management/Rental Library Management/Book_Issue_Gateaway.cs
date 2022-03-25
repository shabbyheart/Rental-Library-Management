using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Library_Management
{
    class Book_Issue_Gateaway
    {

        DBConnector connector = null;
        SqlConnection connection = null;
        Book_Issue Bissue = null;
        List<Book_Issue> bissue = null;

        public Book_Issue_Gateaway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }
        public int check_Student_book_already_rent(Book_Issue BIssue)
        {
            int count=0;
            try
            {
                connection.Open();
                string queryString = " SELECT * FROM Book_Issue WHERE book_id = '" + BIssue.BookId + "' and student_id = '"+ BIssue.StudentId+"' ";

                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                    count++;
                // = Convert.ToInt32(dataReader["quantity"]);
                connection.Close();
            }
            catch(Exception exp)
            {
                count = 0;
                MessageBox.Show(exp.Message);
                connection.Close();
            }
            return count;
        }
        public int  get_book_Quantity_form_Book_Store_Table(Book_Issue BIssue)
        {
            int quantity=0;
            try
            {
                connection.Open();
                
                string queryString = " SELECT quantity FROM Book_store WHERE book_id = '" + BIssue.BookId +"'";
                
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                quantity = Convert.ToInt32( dataReader["quantity"]);
                connection.Close();
                
            }
            catch(Exception exp)
            {
                //MessageBox.Show(exp.Message + "student Status");
                quantity = -1;
                connection.Close();
            }
            return quantity;
        }
        public List<Book_Issue> Book_Status_view(Book_Issue BIssue)
        {
            bissue = new List<Book_Issue>();
            try
            {
                connection.Open();
                //MessageBox.Show(BIssue.BookId.ToString());
                string queryString = "SELECT * FROM Book_Issue WHERE book_id = '" + BIssue.BookId + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                bissue = new List<Book_Issue>();
                while (dataReader.Read())
                {

                    //each iteration it will read one department info
                    Book_Issue newBIssue = new Book_Issue();
                    newBIssue.StudentId = Convert.ToInt32(dataReader["student_id"]);
                    newBIssue.StudentName = dataReader["sutdent_name"].ToString();

                    //MessageBox.Show(newBIssue.StudentName);

                    newBIssue.Department1 = dataReader["department"].ToString();
                    newBIssue.BookId = Convert.ToInt32(dataReader["book_id"].ToString());
                    newBIssue.BookName = dataReader["book_name"].ToString();
                    newBIssue.Author = dataReader["author"].ToString();
                    newBIssue.Publisher = dataReader["publisher"].ToString();
                    newBIssue.IssueDate = dataReader["issue_date"].ToString();
                    //we need to create a list of department
                    bissue.Add(newBIssue);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message+ "book status");
                connection.Close();
            }
            return bissue;
        }

        public List<Book_Issue> student_Status_view(Book_Issue BIssue)
        {
            bissue = new List<Book_Issue>();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM Book_Issue WHERE student_id like '"+ BIssue .StudentId+ "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                bissue = new List<Book_Issue>();
                while (dataReader.Read())
                {
                    
                    //each iteration it will read one department info
                    Book_Issue newBIssue = new Book_Issue();
                    newBIssue.StudentId = Convert.ToInt32(dataReader["student_id"]);
                    newBIssue.StudentName = dataReader["sutdent_name"].ToString();

                    

                    newBIssue.Department1 = dataReader["department"].ToString();
                    newBIssue.BookId = Convert.ToInt32(dataReader["book_id"].ToString());
                    newBIssue.BookName = dataReader["book_name"].ToString();
                    newBIssue.Author = dataReader["author"].ToString();
                    newBIssue.Publisher = dataReader["publisher"].ToString();
                    newBIssue.IssueDate = dataReader["issue_date"].ToString();
                    //we need to create a list of department
                    bissue.Add(newBIssue);
                }
                
                connection.Close();
            }
            catch(Exception exp)
            {
                //MessageBox.Show(exp.Message);
                connection.Close();
            }
            return bissue;
        }

        public Book_Issue Search_Into_Book_Issue_Table(Book_Issue BIssue)
        {
            Book_Issue newBIssue = new Book_Issue();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM Book_Issue WHERE student_id = '" + BIssue.StudentId + "'";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                newBIssue.StudentId = Convert.ToInt32(dataReader["student_id"]);
                newBIssue.StudentName = dataReader["sutdent_name"].ToString();
                newBIssue.Department1 = dataReader["department"].ToString();
                newBIssue.BookId = Convert.ToInt32(dataReader["book_id"]);
                newBIssue.BookName = dataReader["book_name"].ToString();
                newBIssue.Author = dataReader["author"].ToString();
                newBIssue.Publisher = dataReader["publisher"].ToString();
                newBIssue.IssueDate = dataReader["issue_date"].ToString();
                connection.Close();

            }
            catch(Exception exp)
            {
                newBIssue.StudentId = -1;
                
                connection.Close();
            }
            return newBIssue;
        }

        public Book_Issue bookId_textBox_leave_Action(Book_Issue BIssue)
        {
            Book_Issue newBIssue = new Book_Issue();
            try
            {
                 
                connection.Open();
                string insertString = "SELECT book_name,author,publisher FROM Book_store WHERE book_id = '" + BIssue.BookId + "' ";
                SqlCommand command = new SqlCommand(insertString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                newBIssue.BookName = dataReader["book_name"].ToString() ;
                newBIssue.Author = dataReader["author"].ToString();
                newBIssue.Publisher = dataReader["publisher"].ToString();

                connection.Close();
            }
            catch (Exception exp)
            {
                newBIssue.BookId = -1;
                connection.Close();
                //MessageBox.Show(exp.Message + "leave action");

            }
            return newBIssue;
        }
        public Book_Issue studentID_Textbox_leave_action(Book_Issue BIssue)
        {
            Book_Issue newBIssue = new Book_Issue();
            try
            {
                //MessageBox.Show(BIssue.StudentId.ToString());
                connection.Open();
                string insertString = "SELECT first_name,last_name,depertment FROM Student_Registration WHERE student_id = '" + BIssue.StudentId + "' ";
                SqlCommand command = new SqlCommand(insertString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                newBIssue.StudentName = dataReader["first_name"].ToString() +" "+ dataReader["last_name"].ToString();
                newBIssue.Department1 = dataReader["depertment"].ToString();

                connection.Close();
            }
            catch (Exception exp)
            {
                newBIssue.StudentId = -1;
                //MessageBox.Show(exp.Message);
                connection.Close();

            }
            return newBIssue;
        }
        public void update_into_book_issue_Table(Book_Issue BIssue)
        {
            try
            {
                connection.Open();
                string updateString = "UPDATE  Book_Issue SET student_id = '" + BIssue.StudentId + "', sutdent_name = '" + BIssue.StudentName + "', department = '" + BIssue.Department1 + "', book_id ='" + BIssue.BookId + "',  book_name = '" + BIssue.BookName + "', author ='" + BIssue.Author + "', publisher ='" + BIssue.Publisher + "', issue_date='" + BIssue.IssueDate + "' WHERE book_id = '" + BIssue.BookId + "' and student_id = '"+ BIssue.StudentId+"' ";

                SqlCommand command = new SqlCommand(updateString, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                connection.Close();
                return;
            }
            MessageBox.Show("Successfully Update! ");
        }
        public void insert_Into_Book_Issue_Table(Book_Issue BIssue)
        {
           
            try
            {
                connection.Open();
                //MessageBox.Show(BIssue.StudentId.ToString() + BIssue.BookId);
                string queryString = "INSERT INTO Book_Issue values('" + BIssue.StudentId + "','" + BIssue.StudentName + "','" + BIssue.Department1 + "','" + BIssue.BookId + "','" + BIssue.BookName + "','" + BIssue.Author + "','" + BIssue.Publisher + "' ,'" + BIssue.IssueDate + "' )";
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
            MessageBox.Show("Successfully Insert!");
        }



        /// Insert data into Book status table
        public void insert_Into_Due_Book_Status_Table(Book_Issue BIssue)
        {
            try
            {
                connection.Open();
                string queryString = "INSERT INTO Due_Book_Status values('" + BIssue.BookId + "','" + BIssue.BookName + "','" + BIssue.Author + "','" + BIssue.Publisher + "','" + BIssue.IssueDate + "')";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                connection.Close();
                return;
            }
            
        }
        public void insert_Into_Student_Status_Table(Book_Issue BIssue)
        {
            try
            {
                connection.Open();
                string queryString = "INSERT INTO Student_Status values('" + BIssue.StudentId + "','" + BIssue.StudentName + "' ,'" + BIssue.Department1 + "','" + BIssue.BookId + "')";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                connection.Close();
                return;
            }
        }


        public List<Book_Issue> all_student_Status()
        {
            bissue = new List<Book_Issue>();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM Book_Issue ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                bissue = new List<Book_Issue>();
                while (dataReader.Read())
                {

                    
                    Book_Issue newBIssue = new Book_Issue();
                    newBIssue.StudentId = Convert.ToInt32(dataReader["student_id"]);
                    newBIssue.StudentName = dataReader["sutdent_name"].ToString();



                    newBIssue.Department1 = dataReader["department"].ToString();
                    newBIssue.BookId = Convert.ToInt32(dataReader["book_id"].ToString());
                    newBIssue.BookName = dataReader["book_name"].ToString();
                    newBIssue.Author = dataReader["author"].ToString();
                    newBIssue.Publisher = dataReader["publisher"].ToString();
                    newBIssue.IssueDate = dataReader["issue_date"].ToString();
                    //we need to create a list of department
                    bissue.Add(newBIssue);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message);
                connection.Close();
            }
            return bissue;
        }
        public List<Book_Issue> all_book_Status()
        {
            bissue = new List<Book_Issue>();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM Book_Issue ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                bissue = new List<Book_Issue>();
                while (dataReader.Read())
                {


                    Book_Issue newBIssue = new Book_Issue();
                    newBIssue.StudentId = Convert.ToInt32(dataReader["student_id"]);
                    newBIssue.StudentName = dataReader["sutdent_name"].ToString();



                    newBIssue.Department1 = dataReader["department"].ToString();
                    newBIssue.BookId = Convert.ToInt32(dataReader["book_id"].ToString());
                    newBIssue.BookName = dataReader["book_name"].ToString();
                    newBIssue.Author = dataReader["author"].ToString();
                    newBIssue.Publisher = dataReader["publisher"].ToString();
                    newBIssue.IssueDate = dataReader["issue_date"].ToString();
                    //we need to create a list of department
                    bissue.Add(newBIssue);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message);
                connection.Close();
            }
            return bissue;
        }

    }
}
