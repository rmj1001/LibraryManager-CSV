using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoyConn_Test3
{
    public partial class CheckoutReturn : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Library Lib { get; set; }
        public CheckoutReturn(Library lib)
        {
            InitializeComponent();

            this.Lib = lib;
        }

        /// <summary>
        /// Load books and patrons lists to list boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkout_Load(object sender, EventArgs e)
        {
            foreach (Book book in this.Lib.Books)
            {
                booksList.Items.Add(book);
            }

            foreach (Patron patron in this.Lib.Patrons)
            {
                patronsList.Items.Add(patron);
            }
        }

        /// <summary>
        /// Checkout selected book to selected patron
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            int bookIndex = booksList.SelectedIndex;
            int patronIndex = patronsList.SelectedIndex;

            if (bookIndex == -1 || patronIndex == -1)
            {
                MessageBox.Show("You must select a book and a patron!");
                return;
            }

            Book book = (Book)booksList.Items[bookIndex];
            Patron patron = (Patron)patronsList.Items[patronIndex];

            if (!book.IsAvailable)
            {
                MessageBox.Show("Book is already checked out!");
                return;
            }

            book.Checkout();
            patron.CheckoutBook(book.ISBN);

            booksList.Items[bookIndex] = book;
            patronsList.Items[patronIndex] = patron;

            MessageBox.Show($"Book '{book.Title}' checked out successfully!");
        }

        /// <summary>
        /// Set selected book as available and remove from patron list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnBtn_Click(Object sender, EventArgs e)
        {
            int bookIndex = booksList.SelectedIndex;

            if (bookIndex == -1)
            {
                MessageBox.Show("You must select a book!");
                return;
            }

            Book book = (Book)booksList.Items[bookIndex];

            if (book.IsAvailable)
            {
                MessageBox.Show("Book is already returned!");
                return;
            }

            book.Checkout();

            booksList.Items[bookIndex] = book;

            // Find patron who checked out book and remove it from their list of checked out books
            for (int i = 0; i < patronsList.Items.Count; i++)
            {
                Patron patron = (Patron)(patronsList.Items[i]);

                patron.ReturnBookIfCheckedOut(book.ISBN);
            }

            MessageBox.Show($"Book '{book.Title}' returned successfully!");
        }

        /// <summary>
        /// Save books and patrons to library
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        { 
            this.Lib.Books.Clear();
            this.Lib.Patrons.Clear();

            foreach(Book book in booksList.Items)
            {
                this.Lib.Books.Add(book);
            }

            foreach(Patron patron in patronsList.Items)
            {
                this.Lib.Patrons.Add(patron);
            }

            this.Close();
        }
    }
}
