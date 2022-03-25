using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Library_Management
{
    class Book_Search_Gateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        
        List<Book_Issue> bissue = null;

        public Book_Search_Gateway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }
        public List<Book_Search> search_by_Book_name(Book_Search BSearch)
        {
            List<Book_Search> LBSearch = new List<Book_Search>();

            try
            {
                connection.Open();
                //MessageBox.Show(BIssue.BookId.ToString());
                string queryString = "SELECT * FROM Book_store WHERE book_name like  '%" + BSearch.BookName + "%' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                
                while (dataReader.Read())
                {

                    
                    Book_Search newBSearch = new Book_Search();

                    newBSearch.BookId  = Convert.ToInt32(dataReader["book_id"]);
                    newBSearch.BookName = dataReader["book_name"].ToString();
                
                    newBSearch.Author = dataReader["author"].ToString();
                    newBSearch.Publisher = dataReader["publisher"].ToString();
                    newBSearch.Edition = dataReader["edition"].ToString();
                    newBSearch.Year = Convert.ToInt32( dataReader["year"].ToString());
                    newBSearch.Source = dataReader["sourch"].ToString();
                    newBSearch.EntryDate = dataReader["entry_date"].ToString();
                    newBSearch.Quantity = Convert.ToInt32( dataReader["quantity"].ToString());
                    //we need to create a list of department
                    LBSearch.Add(newBSearch);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message+ "book status");
                connection.Close();
            }


            return LBSearch;
        }
        public List<Book_Search> search_by_Book_Author(Book_Search BSearch)
        {
            List<Book_Search> LBSearch = new List<Book_Search>();

            try
            {
                connection.Open();
                //MessageBox.Show(BIssue.BookId.ToString());
                string queryString = "SELECT * FROM Book_store WHERE author like  '%" + BSearch.Author + "%' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {


                    Book_Search newBSearch = new Book_Search();

                    newBSearch.BookId = Convert.ToInt32(dataReader["book_id"]);
                    newBSearch.BookName = dataReader["book_name"].ToString();

                    newBSearch.Author = dataReader["author"].ToString();
                    newBSearch.Publisher = dataReader["publisher"].ToString();
                    newBSearch.Edition = dataReader["edition"].ToString();
                    newBSearch.Year = Convert.ToInt32(dataReader["year"].ToString());
                    newBSearch.Source = dataReader["sourch"].ToString();
                    newBSearch.EntryDate = dataReader["entry_date"].ToString();
                    newBSearch.Quantity = Convert.ToInt32(dataReader["quantity"].ToString());
                    //we need to create a list of department
                    LBSearch.Add(newBSearch);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message+ "book status");
                connection.Close();
            }


            return LBSearch;
        }

        public List<Book_Search> search_by_Book_publisher(Book_Search BSearch)
        {
            List<Book_Search> LBSearch = new List<Book_Search>();

            try
            {
                connection.Open();
                //MessageBox.Show(BIssue.BookId.ToString());
                string queryString = "SELECT * FROM Book_store WHERE publisher like  '%" + BSearch.Publisher + "%' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {


                    Book_Search newBSearch = new Book_Search();

                    newBSearch.BookId = Convert.ToInt32(dataReader["book_id"]);
                    newBSearch.BookName = dataReader["book_name"].ToString();

                    newBSearch.Author = dataReader["author"].ToString();
                    newBSearch.Publisher = dataReader["publisher"].ToString();
                    newBSearch.Edition = dataReader["edition"].ToString();
                    newBSearch.Year = Convert.ToInt32(dataReader["year"].ToString());
                    newBSearch.Source = dataReader["sourch"].ToString();
                    newBSearch.EntryDate = dataReader["entry_date"].ToString();
                    newBSearch.Quantity = Convert.ToInt32(dataReader["quantity"].ToString());
                    //we need to create a list of department
                    LBSearch.Add(newBSearch);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message+ "book status");
                connection.Close();
            }


            return LBSearch;
        }
        public List<Book_Search> show_all_Books()
        {
            List<Book_Search> LBSearch = new List<Book_Search>();

            try
            {
                connection.Open();
                //MessageBox.Show(BIssue.BookId.ToString());
                string queryString = "SELECT * FROM Book_store   ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {


                    Book_Search newBSearch = new Book_Search();

                    newBSearch.BookId = Convert.ToInt32(dataReader["book_id"]);
                    newBSearch.BookName = dataReader["book_name"].ToString();

                    newBSearch.Author = dataReader["author"].ToString();
                    newBSearch.Publisher = dataReader["publisher"].ToString();
                    newBSearch.Edition = dataReader["edition"].ToString();
                    newBSearch.Year = Convert.ToInt32(dataReader["year"].ToString());
                    newBSearch.Source = dataReader["sourch"].ToString();
                    newBSearch.EntryDate = dataReader["entry_date"].ToString();
                    newBSearch.Quantity = Convert.ToInt32(dataReader["quantity"].ToString());
                    //we need to create a list of department
                    LBSearch.Add(newBSearch);
                }

                connection.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message+ "book status");
                connection.Close();
            }


            return LBSearch;
        }

    }
}
