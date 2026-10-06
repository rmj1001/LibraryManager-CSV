namespace RoyConn_Test3
{
    partial class PatronEditor
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
            nameLabel = new Label();
            nameBox = new TextBox();
            idBox = new TextBox();
            idLabel = new Label();
            saveBtn = new Button();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(69, 6);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(245, 27);
            nameBox.TabIndex = 0;
            toolTip.SetToolTip(nameBox, "Enter the patron's name here.");
            // 
            // idBox
            // 
            idBox.Location = new Point(69, 39);
            idBox.Name = "idBox";
            idBox.Size = new Size(245, 27);
            idBox.TabIndex = 1;
            toolTip.SetToolTip(idBox, "Enter the patron's ID here.");
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(36, 42);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 19);
            idLabel.TabIndex = 4;
            idLabel.Text = "ID";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(204, 72);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(110, 42);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            toolTip.SetToolTip(saveBtn, "Click here to save the patron.");
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // PatronEditor
            // 
            AcceptButton = saveBtn;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = saveBtn;
            ClientSize = new Size(326, 125);
            Controls.Add(saveBtn);
            Controls.Add(idBox);
            Controls.Add(idLabel);
            Controls.Add(nameBox);
            Controls.Add(nameLabel);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PatronEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patron Editor";
            Load += PatronEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameBox;
        private TextBox idBox;
        private Label idLabel;
        private Button saveBtn;
        private ToolTip toolTip;
    }
}