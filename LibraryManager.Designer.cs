namespace RoyConn_Test3
{
    partial class LibraryManager
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
            label1 = new Label();
            manageBooks = new Button();
            managePatrons = new Button();
            checkoutBooks = new Button();
            exitBtn = new Button();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 19);
            label1.TabIndex = 4;
            label1.Text = "Select a button to manage a part of the library.";
            // 
            // manageBooks
            // 
            manageBooks.Location = new Point(23, 79);
            manageBooks.Margin = new Padding(4, 3, 4, 3);
            manageBooks.Name = "manageBooks";
            manageBooks.Size = new Size(200, 78);
            manageBooks.TabIndex = 0;
            manageBooks.Text = "Manage &Books";
            toolTip.SetToolTip(manageBooks, "Click here to manage books owned by the library.");
            manageBooks.UseVisualStyleBackColor = true;
            manageBooks.Click += manageBooks_Click;
            // 
            // managePatrons
            // 
            managePatrons.Location = new Point(231, 79);
            managePatrons.Margin = new Padding(4, 3, 4, 3);
            managePatrons.Name = "managePatrons";
            managePatrons.Size = new Size(200, 78);
            managePatrons.TabIndex = 1;
            managePatrons.Text = "Manage &Patrons";
            toolTip.SetToolTip(managePatrons, "Click here to manage library patrons.");
            managePatrons.UseVisualStyleBackColor = true;
            managePatrons.Click += managePatrons_Click;
            // 
            // checkoutBooks
            // 
            checkoutBooks.Location = new Point(438, 79);
            checkoutBooks.Margin = new Padding(4, 3, 4, 3);
            checkoutBooks.Name = "checkoutBooks";
            checkoutBooks.Size = new Size(200, 78);
            checkoutBooks.TabIndex = 2;
            checkoutBooks.Text = "&Checkout/Return Books";
            toolTip.SetToolTip(checkoutBooks, "Click here to checkout/return books.");
            checkoutBooks.UseVisualStyleBackColor = true;
            checkoutBooks.Click += checkoutBooks_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(231, 163);
            exitBtn.Margin = new Padding(4, 3, 4, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(200, 78);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "&Exit Library";
            toolTip.SetToolTip(exitBtn, "Click here to close the library database.");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exit;
            // 
            // LibraryManager
            // 
            AcceptButton = exitBtn;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(661, 318);
            Controls.Add(exitBtn);
            Controls.Add(checkoutBooks);
            Controls.Add(managePatrons);
            Controls.Add(manageBooks);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LibraryManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button manageBooks;
        private Button managePatrons;
        private Button checkoutBooks;
        private Button exitBtn;
        private ToolTip toolTip;
    }
}