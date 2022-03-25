using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Library_Management
{
    class Book_Store
    {
        int bookNumber;
        int bookId;
        string bookName;
        String author;
        String pubisher;
        string edition;
        int year;
        String source;
        String entryDate;
        int Quantity;

        public int BookNumber { get => bookNumber; set => bookNumber = value; }
        public int BookId { get => bookId; set => bookId = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public string Pubisher { get => pubisher; set => pubisher = value; }
        public string Edition { get => edition; set => edition = value; }
        public int Year { get => year; set => year = value; }
        public string Source { get => source; set => source = value; }
        public string EntryDate { get => entryDate; set => entryDate = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
    }
}
