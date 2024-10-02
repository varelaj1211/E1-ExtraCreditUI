namespace E1ExtraCredit
{
    partial class Form1
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
            label1 = new Label();
            SyncButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BookListViiew = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 18);
            label1.Name = "label1";
            label1.Size = new Size(706, 71);
            label1.TabIndex = 0;
            label1.Text = "Welcome to CIS501 Library";
            // 
            // SyncButton
            // 
            SyncButton.Location = new Point(471, 377);
            SyncButton.Name = "SyncButton";
            SyncButton.Size = new Size(306, 46);
            SyncButton.TabIndex = 1;
            SyncButton.Text = "Sync Library from cloud";
            SyncButton.UseVisualStyleBackColor = true;
            SyncButton.Click += SyncButtonClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 89);
            label2.Name = "label2";
            label2.Size = new Size(298, 32);
            label2.TabIndex = 2;
            label2.Text = "Below is our current books";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 167);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 228);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 296);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 5;
            // 
            // BookListViiew
            // 
            BookListViiew.Location = new Point(66, 134);
            BookListViiew.Name = "BookListViiew";
            BookListViiew.Size = new Size(340, 213);
            BookListViiew.TabIndex = 6;
            BookListViiew.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookListViiew);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SyncButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SyncButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView BookListViiew;
    }
}
