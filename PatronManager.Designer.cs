namespace RoyConn_Test3
{
    partial class PatronManager
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
            close = new Button();
            removePatron = new Button();
            editPatron = new Button();
            addPatron = new Button();
            patronsListBox = new ListBox();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // close
            // 
            close.Location = new Point(356, 467);
            close.Name = "close";
            close.Size = new Size(209, 62);
            close.TabIndex = 3;
            close.Text = "&Save && Close";
            toolTip.SetToolTip(close, "Click here to save the patrons and close the window.");
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // removePatron
            // 
            removePatron.Location = new Point(356, 148);
            removePatron.Name = "removePatron";
            removePatron.Size = new Size(209, 62);
            removePatron.TabIndex = 2;
            removePatron.Text = "&Remove Patron";
            toolTip.SetToolTip(removePatron, "Click here to remove the selected patron.");
            removePatron.UseVisualStyleBackColor = true;
            removePatron.Click += removePatron_Click;
            // 
            // editPatron
            // 
            editPatron.Location = new Point(356, 80);
            editPatron.Name = "editPatron";
            editPatron.Size = new Size(209, 62);
            editPatron.TabIndex = 1;
            editPatron.Text = "&Edit Patron";
            toolTip.SetToolTip(editPatron, "Click here to edit the selected patron.");
            editPatron.UseVisualStyleBackColor = true;
            editPatron.Click += editPatron_Click;
            // 
            // addPatron
            // 
            addPatron.Location = new Point(356, 12);
            addPatron.Name = "addPatron";
            addPatron.Size = new Size(209, 62);
            addPatron.TabIndex = 0;
            addPatron.Text = "&Add Patron";
            toolTip.SetToolTip(addPatron, "Click here to add a new patron.");
            addPatron.UseVisualStyleBackColor = true;
            addPatron.Click += addPatron_Click;
            // 
            // patronsListBox
            // 
            patronsListBox.FormattingEnabled = true;
            patronsListBox.Location = new Point(12, 12);
            patronsListBox.Name = "patronsListBox";
            patronsListBox.Size = new Size(338, 517);
            patronsListBox.TabIndex = 4;
            // 
            // PatronManager
            // 
            AcceptButton = close;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = close;
            ClientSize = new Size(573, 536);
            Controls.Add(close);
            Controls.Add(removePatron);
            Controls.Add(editPatron);
            Controls.Add(addPatron);
            Controls.Add(patronsListBox);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PatronManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patron Manager";
            Load += PatronManager_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button close;
        private Button removePatron;
        private Button editPatron;
        private Button addPatron;
        private ListBox patronsListBox;
        private ToolTip toolTip;
    }
}