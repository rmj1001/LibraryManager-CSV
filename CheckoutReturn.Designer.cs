namespace RoyConn_Test3
{
    partial class CheckoutReturn
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
            booksList = new ListBox();
            patronsList = new ListBox();
            checkoutBtn = new Button();
            exitBtn = new Button();
            returnBtn = new Button();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // booksList
            // 
            booksList.FormattingEnabled = true;
            booksList.Location = new Point(12, 12);
            booksList.Name = "booksList";
            booksList.Size = new Size(258, 403);
            booksList.TabIndex = 3;
            // 
            // patronsList
            // 
            patronsList.FormattingEnabled = true;
            patronsList.Location = new Point(276, 12);
            patronsList.Name = "patronsList";
            patronsList.Size = new Size(258, 403);
            patronsList.TabIndex = 4;
            // 
            // checkoutBtn
            // 
            checkoutBtn.Location = new Point(540, 12);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new Size(215, 54);
            checkoutBtn.TabIndex = 0;
            checkoutBtn.Text = "&Checkout Book";
            toolTip.SetToolTip(checkoutBtn, "Click here to checkout the selected book to the selected patron,");
            checkoutBtn.UseVisualStyleBackColor = true;
            checkoutBtn.Click += checkoutBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(540, 132);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(215, 54);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "&Exit";
            toolTip.SetToolTip(exitBtn, "Click here to close the checkout/return window.");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(541, 72);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(215, 54);
            returnBtn.TabIndex = 1;
            returnBtn.Text = "&Return Book";
            toolTip.SetToolTip(returnBtn, "Click here to return the selected book.");
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // CheckoutReturn
            // 
            AcceptButton = exitBtn;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(768, 428);
            Controls.Add(returnBtn);
            Controls.Add(exitBtn);
            Controls.Add(checkoutBtn);
            Controls.Add(patronsList);
            Controls.Add(booksList);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CheckoutReturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            Load += Checkout_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox booksList;
        private ListBox patronsList;
        private Button checkoutBtn;
        private Button exitBtn;
        private Button returnBtn;
        private ToolTip toolTip;
    }
}