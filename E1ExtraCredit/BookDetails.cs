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

        //private int currentPage = 1;
        // private int bookmarkPage = 1;
        public BookDetails(Book book)
        {
            InitializeComponent();
            selectedBook = book;
            LibraryModel model = new LibraryModel();


            Title.Text = $"Title: {book.Title}";
            Author.Text = $"Author: {book.Author}";
            Serial.Text = $"Serial Number: {book.SerialNumber}";
            Page.Text = $"Page: {book.CurrentPage}/{book.Page}";


            NextPageButton.Click += new EventHandler(NextPageButton_Click);
            PrevPageButton.Click += new EventHandler(PrevPageButton_Click);
            BMButton.Click += new EventHandler(BMButton_Click);
            GoToButton.Click += new EventHandler(GoToButton_Click);

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
            controller.GoToPgHandler(selectedBook.CurrentPage, selectedBook);

        }

        private void RemoveBMbutton_Click(object sender, EventArgs e)
        {
            controller.RemoveBMHandler(selectedBook);
        }
    }
}
