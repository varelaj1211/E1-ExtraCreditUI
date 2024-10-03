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
            Author = new Label();
            Title = new Label();
            Serial = new Label();
            Page = new Label();
            BMButton = new Button();
            GoToButton = new Button();
            Bookmark = new Label();
            RemoveBMbutton = new Button();
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
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(106, 98);
            Author.Name = "Author";
            Author.Size = new Size(87, 32);
            Author.TabIndex = 3;
            Author.Text = "Author";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(117, 162);
            Title.Name = "Title";
            Title.Size = new Size(60, 32);
            Title.TabIndex = 4;
            Title.Text = "Title";
            // 
            // Serial
            // 
            Serial.AutoSize = true;
            Serial.Location = new Point(110, 225);
            Serial.Name = "Serial";
            Serial.Size = new Size(167, 32);
            Serial.TabIndex = 5;
            Serial.Text = "Serial Number";
            // 
            // Page
            // 
            Page.AutoSize = true;
            Page.Location = new Point(328, 364);
            Page.Name = "Page";
            Page.Size = new Size(41, 32);
            Page.TabIndex = 6;
            Page.Text = "P#";
            // 
            // BMButton
            // 
            BMButton.Location = new Point(75, 25);
            BMButton.Name = "BMButton";
            BMButton.Size = new Size(150, 46);
            BMButton.TabIndex = 7;
            BMButton.Text = "Book Mark";
            BMButton.UseVisualStyleBackColor = true;
            BMButton.Click += BMButton_Click;
            // 
            // GoToButton
            // 
            GoToButton.Location = new Point(578, 25);
            GoToButton.Name = "GoToButton";
            GoToButton.Size = new Size(150, 46);
            GoToButton.TabIndex = 8;
            GoToButton.Text = "Go To...";
            GoToButton.UseVisualStyleBackColor = true;
            GoToButton.Click += GoToButton_Click;
            // 
            // Bookmark
            // 
            Bookmark.AutoSize = true;
            Bookmark.Location = new Point(587, 119);
            Bookmark.Name = "Bookmark";
            Bookmark.Size = new Size(121, 32);
            Bookmark.TabIndex = 9;
            Bookmark.Text = "Bookmark";
            // 
            // RemoveBMbutton
            // 
            RemoveBMbutton.Location = new Point(328, 25);
            RemoveBMbutton.Name = "RemoveBMbutton";
            RemoveBMbutton.Size = new Size(150, 46);
            RemoveBMbutton.TabIndex = 10;
            RemoveBMbutton.Text = "UnBook Mark";
            RemoveBMbutton.UseVisualStyleBackColor = true;
            RemoveBMbutton.Click += RemoveBMbutton_Click;
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveBMbutton);
            Controls.Add(Bookmark);
            Controls.Add(GoToButton);
            Controls.Add(BMButton);
            Controls.Add(Page);
            Controls.Add(Serial);
            Controls.Add(Title);
            Controls.Add(Author);
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
        private Label Author;
        private Label Title;
        private Label Serial;
        private Label Page;
        private Button BMButton;
        private Button GoToButton;
        private Label Bookmark;
        private Button RemoveBMbutton;
    }
}