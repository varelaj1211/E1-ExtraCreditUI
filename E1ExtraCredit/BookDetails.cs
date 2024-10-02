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
        private int currentPage = 1;
        private int bookmarkPage = 1;
        public BookDetails(Book book)
        {
            InitializeComponent();
            selectedBook = book;

            // Populate book details
            lblTitle.Text = $"Title: {book._title}";
            lblAuthor.Text = $"Author: {book._author}";
            lblSerial.Text = $"Serial Number: {book._serialNumber}";
            lblPage.Text = $"Page: {currentPage}/{book._page}";

            NextPageButton.Enabled = true;
            PrevPageButton.Enabled = true;
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage < selectedBook._page)
            {
                currentPage++;
                lblPage.Text = $"Page: {currentPage}/{selectedBook._page}";
            }
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                lblPage.Text = $"Page: {currentPage}/{selectedBook._page}";
            }
        }

        private void BMButton_Click(object sender, EventArgs e)
        {
            bookmarkPage = currentPage;
            lblBookmark.Text = $"Bookmark saved at page {bookmarkPage}";
        }

        private void GoToButton_Click(object sender, EventArgs e)
        {
            currentPage = bookmarkPage;
            lblPage.Text = $"Page: {currentPage}/{selectedBook._page}";
        }
    }
}
