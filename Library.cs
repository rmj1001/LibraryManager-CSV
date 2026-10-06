using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace RoyConn_Test3
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Patron> Patrons { get; set; }

        public string BooksFile { get; set;  }
        public string PatronsFIle { get; set; }

        public Library(string booksFile, string patronsFIle, bool overwrite = false)
        {
            this.BooksFile = booksFile;
            this.PatronsFIle = patronsFIle;

            this.Books = new List<Book>();
            this.Patrons = new List<Patron>();

            if (overwrite)
            {
                return;
            }

            this.LoadBooks();
            this.LoadPatrons();
        }

        /// <summary>
        /// Load each line in books file as a new Book object in books list
        /// </summary>
        private void LoadBooks()
        {
            try
            {
                string[] books = File.ReadAllLines(this.BooksFile);

                foreach (string book in books)
                {
                    Book bookObj = new Book(book);

                    this.Books.Add(bookObj);
                }
            }
            catch
            {
                // Do nothing, keep lists blank for new databases
            }
        }

        /// <summary>
        /// Load each line in patrons file as a new Patron object in patrons list
        /// </summary>
        private void LoadPatrons()
        {
            try
            {
                string[] patrons = File.ReadAllLines(this.PatronsFIle);

                foreach (string patron in patrons)
                {
                    Patron patronObj = new Patron(patron);

                    this.Patrons.Add(patronObj);
                }
            }
            catch
            {
                // Do nothing, keep lists blank for new databases
            }
        }

        /// <summary>
        /// Export books list to a string, separated by newlines
        /// </summary>
        /// <returns></returns>
        private string BooksCSV()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Book book in this.Books)
            {
                sb.Append(book.ToCSV() + '\n');
            }

            return sb.ToString();
        }

        /// <summary>
        /// Export patrons list to a string, separated by newlines
        /// </summary>
        /// <returns></returns>
        private string PatronsCSV()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Patron patron in this.Patrons)
            {
                sb.Append(patron.ToCSV() + '\n');
            }

            return sb.ToString();
        }

        /// <summary>
        /// Save books and patrons to their respective database files
        /// </summary>
        /// <param name="booksPath"></param>
        /// <param name="patronsPath"></param>
        public void SaveToDisk()
        {
            File.WriteAllText(this.BooksFile, this.BooksCSV());
            File.WriteAllText(this.PatronsFIle, this.PatronsCSV());
        }
    }
}
