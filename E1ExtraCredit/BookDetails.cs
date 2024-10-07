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
        private NextPageDel NextPgHandler;
        private PrevPageDel PrevPgHandler;
        private RemoveBookmarkDel RemoveBM;
        private SetBookmark SelectBM;
        private  GoToDel SelectedPg;
        private LibraryModel model;
        private Status state;
        
        public BookDetails(LibraryModel m, int index, NextPageDel nxtPageDel, PrevPageDel prevPg, RemoveBookmarkDel removeBM, SetBookmark setBM, GoToDel selectedPg)
        {
            InitializeComponent();
            model = m;

            currBook = model.books[index];
            
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


        public void UpdateGameState(Status s)
        {
            state = s;
            switch (state)
            {
                case Status.RemoveBM:
                    StringBuilder sbRemove = new StringBuilder();
                    foreach (int r in currBook.BookMarks)
                    {
                        sbRemove.Append($"Bookmark saved at page {r}\n");
                    }
                    string newRemoved = sbRemove.ToString();
                    Bookmark.Text = newRemoved;
                    break;

                case Status.AddBM:

                    StringBuilder sbAdd = new StringBuilder();
                    foreach (int a in currBook.BookMarks)
                    {
                        sbAdd.Append($"Bookmark saved at page {a}\n");
                    }
                    string newAdded = sbAdd.ToString();
                    Bookmark.Text = newAdded;
                    break;

                case Status.Sync:
                    Bookmark.Text = "";
                    break;

                case Status.NextPg:
                    Page.Text = $"Page: {currBook.CurrentPage}/{currBook.Page}";
                    break;

                case Status.PrevPg:
                    Page.Text = $"Page: {currBook.CurrentPage}/{currBook.Page}";
                    break;

                case Status.GoToPg:
                    int crp = currBook.CurrentPage;
                    Page.Text = $"Page: {currBook.CurrentPage}/{currBook.Page}";
                    GoToPageTextBox.Clear();
                    break;
               

            }
            
        
        
        
        }


        private void NextPageButton_Click(object sender, EventArgs e)
        {
            NextPgHandler(currBook);
            
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            PrevPgHandler(currBook);
            
        }

        private void BMButton_Click(object sender, EventArgs e)
        {
            
            SelectBM(currBook, currBook.BookMarks);
        }

        private void GoToButton_Click(object sender, EventArgs e)
        {
            
            SelectedPg(int.Parse(GoToPageTextBox.Text), currBook);
            
        }

        private void RemoveBMbutton_Click(object sender, EventArgs e)
        { 
            RemoveBM(currBook, currBook.BookMarks);
            
        }
    }
}
