using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoyConn_Test3
{
    public partial class LibraryManager : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Library Lib { get; set; }

        public LibraryManager(Library lib)
        {
            InitializeComponent();
            this.Lib = lib;
        }

        /// <summary>
        /// Open the BookManager window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manageBooks_Click(object sender, EventArgs e)
        {
            BookManager manager = new BookManager(this.Lib);

            manager.ShowDialog();
        }

        /// <summary>
        /// Save the library to disk and close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit(object sender, EventArgs e)
        {
            this.Lib.SaveToDisk();
            this.Close();
        }

        /// <summary>
        /// Open the PatronManager window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void managePatrons_Click(object sender, EventArgs e)
        {
            PatronManager manager = new PatronManager(this.Lib);

            manager.ShowDialog();
        }

        /// <summary>
        /// Open the CheckoutReturn window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkoutBooks_Click(object sender, EventArgs e)
        {
            CheckoutReturn checkout = new CheckoutReturn(this.Lib);

            checkout.ShowDialog();
        }
    }
}
