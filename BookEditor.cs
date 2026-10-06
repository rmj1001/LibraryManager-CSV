using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoyConn_Test3
{
    public partial class BookEditor : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Book CurrentBook { get; set; }
        public BookEditor(ref Book book)
        {
            InitializeComponent();

            CurrentBook = book;
        }

        /// <summary>
        /// Load selected book data into window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookEditor_Load(object sender, EventArgs e)
        {
            titleBox.Text = CurrentBook.Title;
            authorBox.Text = CurrentBook.Author;
            isbnBox.Text = CurrentBook.ISBN;
        }

        /// <summary>
        /// Save contents in text boxes to book if all text boxes are filled out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleBox.Text))
            {
                MessageBox.Show("The book must have a title!");
                return;
            }

            if (string.IsNullOrEmpty(authorBox.Text))
            {
                MessageBox.Show("The book must have an author!");
                return;
            }

            if (string.IsNullOrEmpty(isbnBox.Text))
            {
                MessageBox.Show("The book must have an ISBN!");
                return;
            }

            CurrentBook.Title = titleBox.Text;
            CurrentBook.Author = authorBox.Text;
            CurrentBook.ISBN = isbnBox.Text;

            this.Close();
        }
    }
}
