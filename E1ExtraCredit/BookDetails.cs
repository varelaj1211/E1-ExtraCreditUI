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

        private Book currBook;
        private  NextPageDel NextPgHandler;
        private PrevPageDel PrevPgHandler;
        private RemoveBookmarkDel RemoveBM;
        private SetBookmark SelectBM;
        private  GoToDel SelectedPg;
        private LibraryModel model;
        private int index;



        public BookDetails(LibraryModel m, int index, NextPageDel nxtPageDel, PrevPageDel prevPg, RemoveBookmarkDel removeBM, SetBookmark setBM, GoToDel selectedPg)
        {
            InitializeComponent();
            model = m;

            currBook = m.books[index];
            
            Title.Text = $"Title: {currBook.Title}";
            Author.Text = $"Author: {currBook.Author}";
            Serial.Text = $"Serial Number: {currBook.SerialNumber}";
            Page.Text = $"Page: {currBook.CurrentPage}/{currBook.Page}";
            GoToPageTextBox.Text = "";

            StringBuilder sb = new StringBuilder();
            foreach (int s in currBook.BookMarks)
            {
                sb.Append($"Bookmark saved at page {s}\n");
            }
            Bookmark.Text = sb.ToString();

            NextPageButton.Enabled = true;
            PrevPageButton.Enabled = true;
            this.PrevPgHandler = prevPg;
            this.NextPgHandler = nxtPageDel;
            this.RemoveBM = removeBM;
            this.SelectBM = setBM;
            this.SelectedPg = selectedPg;
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            NextPgHandler(currBook);
            Page.Text = $"Page: {currBook.CurrentPage}/{currBook.Page}";
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            PrevPgHandler(currBook);
            Page.Text = $"Page: {currBook.CurrentPage}/{currBook.Page}";
        }

        private void BMButton_Click(object sender, EventArgs e)
        {
            
            Bookmark.Text = SelectBM(currBook);
        }

        private void GoToButton_Click(object sender, EventArgs e)
        {
            int crp = currBook.CurrentPage;
            SelectedPg(int.Parse(GoToPageTextBox.Text), currBook);
            if (currBook.CurrentPage == crp) MessageBox.Show("Invalid Page\n\nPlease try again");
            Page.Text = $"Page: {currBook.CurrentPage}/{currBook.Page}";
            GoToPageTextBox.Clear();
        }

        private void RemoveBMbutton_Click(object sender, EventArgs e)
        { 
            Bookmark.Text = RemoveBM(currBook);
            
        }
    }
}
