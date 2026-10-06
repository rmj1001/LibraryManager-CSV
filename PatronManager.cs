using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoyConn_Test3
{
    public partial class PatronManager : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Library Lib { get; set; }
        public PatronManager(Library lib)
        {
            InitializeComponent();

            this.Lib = lib;
        }

        /// <summary>
        /// Load patrons from library list to listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatronManager_Load(object sender, EventArgs e)
        {
            foreach (Patron patron in this.Lib.Patrons)
            {
                patronsListBox.Items.Add(patron);
            }
        }

        /// <summary>
        /// Save patrons and exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            this.Lib.Patrons.Clear();

            foreach (Patron patron in patronsListBox.Items)
            {
                this.Lib.Patrons.Add(patron);
            }

            this.Close();
        }

        /// <summary>
        /// Remove selected patron
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removePatron_Click(object sender, EventArgs e)
        {
            int index = patronsListBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("You must select a patron to remove.");
                return;
            }

            patronsListBox.Items.RemoveAt(index);
        }

        /// <summary>
        /// Add a new patron and edit in PatronEditor window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPatron_Click(object sender, EventArgs e)
        {
            Patron newPatron = new Patron();

            PatronEditor editor = new PatronEditor(ref newPatron);

            editor.ShowDialog();

            patronsListBox.Items.Add(newPatron);
        }

        /// <summary>
        /// Edit selected patron in PatronEditor window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editPatron_Click(object sender, EventArgs e)
        {
            int index = patronsListBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("You must select a patron to edit.");
                return;
            }

            Patron currentPatron = (Patron)patronsListBox.Items[index];

            PatronEditor editor = new PatronEditor(ref currentPatron);

            editor.ShowDialog();

            patronsListBox.Items[index] = currentPatron;
        }
    }
}
