using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Library_Management
{
    class Book_Search
    {
        int bookId;
        string bookName;
        string author;
        string publisher;
        string edition;
        int year;
        string source;
        string entryDate;
        int quantity;

        public int BookId { get => bookId; set => bookId = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Edition { get => edition; set => edition = value; }
        public int Year { get => year; set => year = value; }
        public string Source { get => source; set => source = value; }
        public string EntryDate { get => entryDate; set => entryDate = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
