/* Roy Conn
 * CPT-185-C01H
 * Test 3 - Final Exam - Library Manager
 */

using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace RoyConn_Test3
{
    public partial class MainWindow : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Library Lib { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save the library to disk and exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Lib.SaveToDisk();
            this.Close();
        }

        /// <summary>
        /// Load books and patrons databases into memory and open LibraryManager window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openLibrary_Click(object sender, EventArgs e)
        {
            string booksPath;
            string patronsPath;

            MessageBox.Show("Open the books database.");

            if (openFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Cancelled opening databaes.");
                return;
            }

            booksPath = openFile.FileName;

            MessageBox.Show("Open the patrons database.");

            if (openFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Cancelled opening databaes.");
                return;
            }

            patronsPath = openFile.FileName;

            this.Lib = new Library(booksPath, patronsPath);

            LibraryManager libMan = new LibraryManager(this.Lib);

            libMan.ShowDialog();
        }

        /// <summary>
        /// Create new books and patrons databases and open LibraryManager window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newLibrary_Click(Object sender, EventArgs e)
        {
            string booksPath;
            string patronsPath;

            MessageBox.Show("Save the books database.");

            if (saveFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Cancelled opening databaes.");
                return;
            }

            booksPath = saveFile.FileName;

            MessageBox.Show("Save the patrons database.");

            if (saveFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Cancelled opening databaes.");
                return;
            }

            patronsPath = saveFile.FileName;

            this.Lib = new Library(booksPath, patronsPath, overwrite: true);

            LibraryManager libman = new LibraryManager(this.Lib);

            libman.ShowDialog();
        }
    }
}
