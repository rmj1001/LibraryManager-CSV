namespace RoyConn_Test3
{
    partial class BookManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            booksListBox = new ListBox();
            addBook = new Button();
            editBook = new Button();
            removeBook = new Button();
            close = new Button();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // booksListBox
            // 
            booksListBox.FormattingEnabled = true;
            booksListBox.Location = new Point(12, 12);
            booksListBox.Name = "booksListBox";
            booksListBox.Size = new Size(338, 517);
            booksListBox.TabIndex = 4;
            // 
            // addBook
            // 
            addBook.Location = new Point(356, 12);
            addBook.Name = "addBook";
            addBook.Size = new Size(209, 62);
            addBook.TabIndex = 0;
            addBook.Text = "&Add Book";
            toolTip.SetToolTip(addBook, "Click here to add a new book.");
            addBook.UseVisualStyleBackColor = true;
            addBook.Click += addBook_Click;
            // 
            // editBook
            // 
            editBook.Location = new Point(356, 80);
            editBook.Name = "editBook";
            editBook.Size = new Size(209, 62);
            editBook.TabIndex = 1;
            editBook.Text = "&Edit Book";
            toolTip.SetToolTip(editBook, "Click here to edit the selected book.");
            editBook.UseVisualStyleBackColor = true;
            editBook.Click += editBook_Click;
            // 
            // removeBook
            // 
            removeBook.Location = new Point(356, 148);
            removeBook.Name = "removeBook";
            removeBook.Size = new Size(209, 62);
            removeBook.TabIndex = 2;
            removeBook.Text = "&Remove Book";
            toolTip.SetToolTip(removeBook, "Click here to remove the selected book.");
            removeBook.UseVisualStyleBackColor = true;
            removeBook.Click += removeBook_Click;
            // 
            // close
            // 
            close.Location = new Point(356, 467);
            close.Name = "close";
            close.Size = new Size(209, 62);
            close.TabIndex = 3;
            close.Text = "&Save && Close";
            toolTip.SetToolTip(close, "Click here to save the books list.");
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // BookManager
            // 
            AcceptButton = close;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = close;
            ClientSize = new Size(580, 546);
            Controls.Add(close);
            Controls.Add(removeBook);
            Controls.Add(editBook);
            Controls.Add(addBook);
            Controls.Add(booksListBox);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BookManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            Load += BookManager_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox booksListBox;
        private Button addBook;
        private Button editBook;
        private Button removeBook;
        private Button close;
        private ToolTip toolTip;
    }
}