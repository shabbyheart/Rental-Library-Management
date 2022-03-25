using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Library_Management
{
    class Book_Store_Gateaway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        
        public Book_Store_Gateaway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }

        

        public Book_Store search_into_Book_Store_Table(Book_Store BStore)
        {
            Book_Store newBStore = new Book_Store();
            try
            {
                connection.Open();
                string queryString = "SELECT * FROM Book_store WHERE book_id = '" + BStore.BookId + "'";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                    newBStore.BookId = Convert.ToInt32( dataReader["book_id"]);
                    newBStore.BookName = dataReader["book_name"].ToString();
                    newBStore.Author = dataReader["author"].ToString();
                    newBStore.Pubisher = dataReader["publisher"].ToString();

                newBStore.Edition = dataReader["edition"].ToString();
                newBStore.Year = Convert.ToInt32( dataReader["year"]);
                newBStore.Source = dataReader["sourch"].ToString();
                newBStore.EntryDate = dataReader["entry_date"].ToString();
                newBStore.Quantity1 = Convert.ToInt32(dataReader["quantity"]);



                connection.Close();
            }
            catch
            {
                newBStore.BookId = -1;
                MessageBox.Show("Wrong book Id");
                connection.Close();
            }

            return newBStore;

        }
        public void insert_Into_publisher_Table( Book_Store BStore)
        {
            try
            {
                connection.Open();
                string insertString = "INSERT INTO Publisher values('" + BStore.Pubisher + "','" + BStore.BookName + "','" + BStore.Edition + "' )";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
               
            }
        }
        public void insert_Into_Author_Table(Book_Store BStore)
        {
            try
            {
                connection.Open();
                string insertString = "INSERT INTO Author values( '" + BStore.Author + "','" + BStore.BookName + "')";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
        public void delete(Book_Store  BStore)
        {
            try
            {
                connection.Open();
                string deleteString = " DELETE FROM Book_store WHERE book_id = '" + BStore.BookId + "' ";

                SqlCommand command = new SqlCommand(deleteString, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                connection.Close();
                return;
            }
            MessageBox.Show("Successfully Delete! ");
        }
        public void update_Book_Store_Table( Book_Store BStore)
        {
            try
            {
                connection.Open();
                string insertString = "UPDATE  Book_store SET book_name = '" + BStore.BookName + "' , author = '" + BStore.Author + "', publisher = '" + BStore.Pubisher + "', edition = '" + BStore.Edition + "', year = '" + BStore.Year + "', sourch = '" + BStore.Source + "' , entry_date = '" + BStore.EntryDate + "' , quantity = '" + BStore.Quantity1 + "'  WHERE  book_id = '" + BStore.BookId + "' ";
                //MessageBox.Show(BStore.BookId.ToString());
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            MessageBox.Show("Update Successfully!");
        }
        public Book_Store row_Count()
        {
            Book_Store rowCount = new Book_Store();
            try
            {
                connection.Open();
                String   insertString = "SELECT COUNT(*) as rowNo FROM Book_store";
                SqlCommand command = new SqlCommand(insertString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                rowCount.BookNumber = Convert.ToInt32( dataReader["rowNo"]);
                rowCount.BookNumber = rowCount.BookNumber + 1;
                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            return rowCount;


        }
        public void insert_Into_Book_Store_Table(Book_Store BStore)
        {
            try
            {
                connection.Open();
                string insertString = "INSERT INTO Book_store values('" + BStore.BookId + "','" + BStore.BookName + "','" + BStore.Author + "','" + BStore.Pubisher + "','" + BStore.Edition + "','" + BStore.Year + "','" + BStore.Source + "' ,'" + BStore.EntryDate + "','" + BStore.Quantity1 + "' )";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("This Book Id Already taken: ");
                connection.Close();
                return;
            }
            MessageBox.Show("Successfully Insert!");
            
        }

    }
}
