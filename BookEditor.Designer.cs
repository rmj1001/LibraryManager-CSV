namespace RoyConn_Test3
{
    partial class BookEditor
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
            titleBox = new TextBox();
            authorBox = new TextBox();
            authorLabel = new Label();
            isbnBox = new TextBox();
            isbnLabel = new Label();
            saveBtn = new Button();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(28, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(36, 17);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Title";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(79, 13);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(255, 23);
            titleBox.TabIndex = 0;
            toolTip.SetToolTip(titleBox, "Enter the book title here.");
            // 
            // authorBox
            // 
            authorBox.Location = new Point(79, 46);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(255, 23);
            authorBox.TabIndex = 1;
            toolTip.SetToolTip(authorBox, "Enter the author first and last name here.");
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(12, 49);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(52, 17);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Author";
            // 
            // isbnBox
            // 
            isbnBox.Location = new Point(79, 79);
            isbnBox.Name = "isbnBox";
            isbnBox.Size = new Size(255, 23);
            isbnBox.TabIndex = 2;
            toolTip.SetToolTip(isbnBox, "Enter the ISBN here.");
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Location = new Point(25, 82);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(40, 17);
            isbnLabel.TabIndex = 6;
            isbnLabel.Text = "ISBN";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(231, 112);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(103, 37);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            toolTip.SetToolTip(saveBtn, "Click here to save the book.");
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // BookEditor
            // 
            AcceptButton = saveBtn;
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = saveBtn;
            ClientSize = new Size(361, 171);
            Controls.Add(saveBtn);
            Controls.Add(isbnBox);
            Controls.Add(isbnLabel);
            Controls.Add(authorBox);
            Controls.Add(authorLabel);
            Controls.Add(titleBox);
            Controls.Add(nameLabel);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BookEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Editor";
            toolTip.SetToolTip(this, "s");
            Load += BookEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox titleBox;
        private TextBox authorBox;
        private Label authorLabel;
        private TextBox isbnBox;
        private Label isbnLabel;
        private Button saveBtn;
        private ToolTip toolTip;
    }
}