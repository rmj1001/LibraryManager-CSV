using System;
using System.Collections.Generic;
using System.Text;

namespace RoyConn_Test3
{
    public class Patron
    {
        // Patron Data
        public string Name { get; set; }
        public string PatronID { get; set; }
        public List<string> BorrowedBooks { get; set; }

        // Invalid patron exception
        public Exception InvalidPatron { get { return new Exception("Invalid patron CSV"); } }

        // Delimiter
        public char Delimiter { get { return '|'; } }

        public Patron()
        {
            this.Name = "";
            this.PatronID = "";
            this.BorrowedBooks = new List<string>();
        }

        /// <summary>
        /// Create patron from parameterized data
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public Patron(string name, string id)
        {
            this.Name = name;
            this.PatronID = id;
            this.BorrowedBooks = new List<string>();
        }

        /// <summary>
        /// Load patron from CSV
        /// </summary>
        /// <param name="csv"></param>
        public Patron(string csv)
        {
            string[] parts = csv.Split(this.Delimiter);

            if (parts.Length != 3)
            {
                throw this.InvalidPatron;
            }

            if (string.IsNullOrEmpty(parts[0]) || string.IsNullOrEmpty(parts[1]))
            {
                throw this.InvalidPatron;
            }

            this.Name = parts[0];
            this.PatronID = parts[1];
            this.BorrowedBooks = new List<string>();

            string[] books = parts[2].Split(',');

            foreach (string book in books)
            {
                this.BorrowedBooks.Add(book);
            }
        }

        /// <summary>
        /// Export patron to CSV string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        public string ToCSV()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Name + this.Delimiter);
            sb.Append(this.PatronID + this.Delimiter);

            StringBuilder books = new StringBuilder();

            foreach (string book in this.BorrowedBooks)
            {
                if (!string.IsNullOrEmpty(book))
                {
                    books.Append(book + ',');
                }
            }

            sb.Append(books);

            return sb.ToString();
        }

        /// <summary>
        /// Check out book by ISBN
        /// </summary>
        /// <param name="isbn"></param>
        public void CheckoutBook(string isbn)
        {
            this.BorrowedBooks.Add(isbn);
        }

        /// <summary>
        /// Return book by ISBN
        /// </summary>
        /// <param name="isbn"></param>
        public void ReturnBookIfCheckedOut(string isbn)
        {
            if (this.HasBook(isbn))
            {
                this.BorrowedBooks.Remove(isbn);
            }
        }

        /// <summary>
        /// Check to see if the patron has a book isbn
        /// </summary>
        /// <param name="isbn"></param>
        public bool HasBook(string isbn)
        {
            return this.BorrowedBooks.Contains(isbn);
        }
    }
}
