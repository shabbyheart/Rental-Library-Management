using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Library_Management
{
    class Book_Receive
    {
        int studentId;
        string studentName;
        string department;
        int bookId;
        string bookName;
        string author;
        string publisher;
        string issueDate;
        string returnDate;
        string overDate;
        double fine;

        public int StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string Department { get => department; set => department = value; }
        public int BookId { get => bookId; set => bookId = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string IssueDate { get => issueDate; set => issueDate = value; }
        public string ReturnDate { get => returnDate; set => returnDate = value; }
        public string OverDate { get => overDate; set => overDate = value; }
        public double Fine { get => fine; set => fine = value; }
    }
}
