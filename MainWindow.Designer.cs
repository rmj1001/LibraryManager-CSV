namespace RoyConn_Test3
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            exitBtn = new Button();
            openFile = new OpenFileDialog();
            tooltip = new ToolTip(components);
            openLibrary = new Button();
            newLibrary = new Button();
            saveFile = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 25);
            label1.Name = "label1";
            label1.Size = new Size(260, 19);
            label1.TabIndex = 3;
            label1.Text = "Welcome to the Library Manager!";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(431, 110);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(197, 76);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "&Exit";
            tooltip.SetToolTip(exitBtn, "Exit the program");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            // 
            // openLibrary
            // 
            openLibrary.Location = new Point(228, 110);
            openLibrary.Margin = new Padding(3, 2, 3, 2);
            openLibrary.Name = "openLibrary";
            openLibrary.Size = new Size(197, 76);
            openLibrary.TabIndex = 1;
            openLibrary.Text = "&Open Library";
            tooltip.SetToolTip(openLibrary, "Click here to open a library database.");
            openLibrary.UseVisualStyleBackColor = true;
            openLibrary.Click += openLibrary_Click;
            // 
            // newLibrary
            // 
            newLibrary.Location = new Point(25, 110);
            newLibrary.Margin = new Padding(3, 2, 3, 2);
            newLibrary.Name = "newLibrary";
            newLibrary.Size = new Size(197, 76);
            newLibrary.TabIndex = 0;
            newLibrary.Text = "&New Library";
            tooltip.SetToolTip(newLibrary, "Click here to create a new library database.");
            newLibrary.UseVisualStyleBackColor = true;
            newLibrary.Click += newLibrary_Click;
            // 
            // MainWindow
            // 
            AcceptButton = exitBtn;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(645, 216);
            Controls.Add(newLibrary);
            Controls.Add(openLibrary);
            Controls.Add(exitBtn);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roy Conn Test 3 Library Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button exitBtn;
        private OpenFileDialog openFile;
        private ToolTip tooltip;
        private Button openLibrary;
        private Button newLibrary;
        private SaveFileDialog saveFile;
    }
}
