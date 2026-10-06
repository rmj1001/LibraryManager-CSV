using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoyConn_Test3
{
    public partial class PatronEditor : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Patron CurrentPatron { get; set; }
        public PatronEditor(ref Patron patron)
        {
            InitializeComponent();

            this.CurrentPatron = patron;
        }

        /// <summary>
        /// Load selected patron data into window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatronEditor_Load(object sender, EventArgs e)
        {
            nameBox.Text = this.CurrentPatron.Name;
            idBox.Text = this.CurrentPatron.PatronID;
        }

        /// <summary>
        /// Save contents in text boxes to patron if all text boxes are filled out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("The patron must have a name!");
                return;
            }

            if (string.IsNullOrEmpty(idBox.Text))
            {
                MessageBox.Show("The patron must have an ID!");
                return;
            }

            this.CurrentPatron.Name = nameBox.Text;
            this.CurrentPatron.PatronID = idBox.Text;

            this.Close();
        }
    }
}
