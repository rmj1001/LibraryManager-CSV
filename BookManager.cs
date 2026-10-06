using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace RoyConn_Test3
{
    public partial class BookManager : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Library Lib { get; set; }
        public BookManager(Library lib)
        {
            InitializeComponent();
            this.Lib = lib;
        }

        /// <summary>
        /// Load books from library to list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookManager_Load(object sender, EventArgs e)
        {
            booksListBox.Items.Clear();


            foreach (Book book in Lib.Books)
            {
                booksListBox.Items.Add(book);
            }
        }

        /// <summary>
        /// Save books from list box to library and close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            this.Lib.Books.Clear();

            foreach (Book book in booksListBox.Items)
            {
                this.Lib.Books.Add(book);
            }

            this.Close();
        }

        /// <summary>
        /// Open book editor window and add new book to list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBook_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();

            BookEditor editor = new BookEditor(ref newBook);

            editor.ShowDialog();

            booksListBox.Items.Add(newBook);
        }

        /// <summary>
        /// Edit a selected book in editor window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBook_Click(object sender, EventArgs e)
        {
            int index = booksListBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("You must select a book to edit.");
                return;
            }

            Book currentBook = (Book)booksListBox.Items[index];

            BookEditor editor = new BookEditor(ref currentBook);

            editor.ShowDialog();

            booksListBox.Items[index] = currentBook;
        }

        /// <summary>
        /// Remove selected book from listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeBook_Click(object sender, EventArgs e)
        {
            int index = booksListBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("You must select a book to remove.");
                return;
            }

            booksListBox.Items.RemoveAt(index);
        }
    }
}
