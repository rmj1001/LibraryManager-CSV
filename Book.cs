using System;
using System.Collections.Generic;
using System.Text;

namespace RoyConn_Test3
{
    public class Book
    {
        // Book data
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        // CSV Delimiter
        public char Delimiter
        {
            get
            {
                return '|';
            }
        }

        /// <summary>
        /// Blank Book
        /// </summary>
        public Book()
        {
            this.Title = "";
            this.Author = "";
            this.ISBN = "";
            this.IsAvailable = true;
        }

        public Exception InvalidBook { get { return new Exception("Invalid book CSV."); } }

        /// <summary>
        /// Create book from parameterized data
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="available"></param>
        public Book(string title, string author, string isbn, bool available = true)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.IsAvailable = available;
        }
        
        /// <summary>
        /// Create book from CSV String
        /// </summary>
        /// <param name="csv"></param>
        /// <exception cref="Exception"></exception>
        public Book(string csv)
        {
            string[] parts = csv.Split(this.Delimiter);

            if (parts.Length != 4)
            {
                throw this.InvalidBook;
            }

            foreach (string part in parts)
            {
                if (part == "" || part == null || part.Length == 0)
                {
                    throw this.InvalidBook;
                }
            }

            this.Title = parts[0];
            this.Author = parts[1];
            this.ISBN = parts[2];

            try
            {
                this.IsAvailable = bool.Parse(parts[3]);
            }
            catch
            {
                throw this.InvalidBook;
            }
        }

        /// <summary>
        /// Export book as a string for listboxes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string checkedOut = "Not Checked";

            if (!this.IsAvailable)
            {
                checkedOut = "Checked out";
            }

            return $"{this.Title} - {checkedOut}";
        }

        /// <summary>
        /// Export book as a CSV string
        /// </summary>
        /// <returns></returns>
        public string ToCSV()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Title}{this.Delimiter}");
            sb.Append($"{this.Author}{this.Delimiter}");
            sb.Append($"{this.ISBN}{this.Delimiter}");
            sb.Append($"{this.IsAvailable}");

            return sb.ToString();
        }

        /// <summary>
        /// Set available status to false
        /// </summary>
        public void Checkout()
        {
            this.IsAvailable = false;
        }

        /// <summary>
        /// Set available statis to true
        /// </summary>
        public void Return()
        {
            this.IsAvailable = true;
        }
    }    
}
