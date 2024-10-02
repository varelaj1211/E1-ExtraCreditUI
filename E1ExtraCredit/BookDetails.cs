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
        private int bookMarkPage = 1;
        public BookDetails(Book book)
        {
            InitializeComponent();
            selectedBook = book;

            // Populate book details
            lblTitle.Text = $"Title: {book._title}";
            lblAuthor.Text = $"Author: {book._author}";
            lblSerial.Text = $"Serial Number: {book._serialNumber}";
            lblPage.Text = $"Page: {currentPage}/{book._page}";

        }
    }
}
