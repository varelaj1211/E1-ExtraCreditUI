namespace E1ExtraCredit
{
    partial class BookDetails
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
            button1 = new Button();
            NextPageButton = new Button();
            PrevPageButton = new Button();
            lblAuthor = new Label();
            lblTitle = new Label();
            lblSerial = new Label();
            lblPage = new Label();
            BMButton = new Button();
            GoToButton = new Button();
            lblBookmark = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(624, 378);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // NextPageButton
            // 
            NextPageButton.Location = new Point(587, 361);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(150, 46);
            NextPageButton.TabIndex = 1;
            NextPageButton.Text = "Next Page";
            NextPageButton.UseVisualStyleBackColor = true;
            NextPageButton.Click += NextPageButton_Click;
            // 
            // PrevPageButton
            // 
            PrevPageButton.Location = new Point(52, 359);
            PrevPageButton.Name = "PrevPageButton";
            PrevPageButton.Size = new Size(150, 46);
            PrevPageButton.TabIndex = 2;
            PrevPageButton.Text = "Previous Page";
            PrevPageButton.UseVisualStyleBackColor = true;
            PrevPageButton.Click += PrevPageButton_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(106, 98);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(87, 32);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(117, 162);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(60, 32);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title";
            // 
            // lblSerial
            // 
            lblSerial.AutoSize = true;
            lblSerial.Location = new Point(110, 225);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(167, 32);
            lblSerial.TabIndex = 5;
            lblSerial.Text = "Serial Number";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(328, 364);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(41, 32);
            lblPage.TabIndex = 6;
            lblPage.Text = "P#";
            // 
            // BMButton
            // 
            BMButton.Location = new Point(139, 25);
            BMButton.Name = "BMButton";
            BMButton.Size = new Size(150, 46);
            BMButton.TabIndex = 7;
            BMButton.Text = "Book Mark";
            BMButton.UseVisualStyleBackColor = true;
            BMButton.Click += BMButton_Click;
            // 
            // GoToButton
            // 
            GoToButton.Location = new Point(407, 25);
            GoToButton.Name = "GoToButton";
            GoToButton.Size = new Size(150, 46);
            GoToButton.TabIndex = 8;
            GoToButton.Text = "Go To...";
            GoToButton.UseVisualStyleBackColor = true;
            GoToButton.Click += GoToButton_Click;
            // 
            // lblBookmark
            // 
            lblBookmark.AutoSize = true;
            lblBookmark.Location = new Point(587, 119);
            lblBookmark.Name = "lblBookmark";
            lblBookmark.Size = new Size(121, 32);
            lblBookmark.TabIndex = 9;
            lblBookmark.Text = "Bookmark";
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBookmark);
            Controls.Add(GoToButton);
            Controls.Add(BMButton);
            Controls.Add(lblPage);
            Controls.Add(lblSerial);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(PrevPageButton);
            Controls.Add(NextPageButton);
            Controls.Add(button1);
            Name = "BookDetails";
            Text = "BookDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button NextPageButton;
        private Button PrevPageButton;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblSerial;
        private Label lblPage;
        private Button BMButton;
        private Button GoToButton;
        private Label lblBookmark;
    }
}