using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1ExtraCredit
{
    public partial class BookDetails : Form
    {

        private Book selectedBook;
        private Controller controller;

        
        public BookDetails(Book book)
        {
            InitializeComponent();
            selectedBook = book;
            LibraryModel model = new LibraryModel();


            Title.Text = $"Title: {book.Title}";
            Author.Text = $"Author: {book.Author}";
            Serial.Text = $"Serial Number: {book.SerialNumber}";
            Page.Text = $"Page: {book.CurrentPage}/{book.Page}";
            GoToPageTextBox.Text = "";

            StringBuilder sb = new StringBuilder();
            foreach (int s in book.BookMarks)
            {
                sb.Append($"Bookmark saved at page {s}\n");
            }
            Bookmark.Text = sb.ToString();



            controller = new Controller(model, Page, Bookmark);

            NextPageButton.Enabled = true;
            PrevPageButton.Enabled = true;
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            controller.NextPgHandler(selectedBook);
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            controller.PrevPgHandler(selectedBook);
        }

        private void BMButton_Click(object sender, EventArgs e)
        {
            controller.SelectBMHandler(selectedBook);
        }

        private void GoToButton_Click(object sender, EventArgs e)
        {
            int crp = selectedBook.CurrentPage;
            controller.GoToPgHandler(int.Parse(GoToPageTextBox.Text), selectedBook);
            if (selectedBook.CurrentPage == crp) MessageBox.Show("Invalid Page\n\nPlease try again");
            GoToPageTextBox.Clear();
            

        }

        private void RemoveBMbutton_Click(object sender, EventArgs e)
        { 
            controller.RemoveBMHandler(selectedBook);
            
        }
    }
}
