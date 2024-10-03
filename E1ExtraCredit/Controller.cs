using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E1ExtraCredit
{
    
    public class Controller
    {
        private LibraryModel model;
        private Label _page;
        private Label _bookmark;

        

        public Controller(LibraryModel m, Label page, Label bookmark)
        {
            model = m;
            _page = page;
            _bookmark = bookmark;
        }

        public void GoToPgHandler(int page, Book book)
        {
            book.CurrentPage = page;
            _page.Text = $"Page: {book.CurrentPage}/{book.Page}";
        }


        public void NextPgHandler(Book book)
        {
            if (book.CurrentPage < book.Page)
            {
                book.CurrentPage++;
                _page.Text = $"Page: {book.CurrentPage}/{book.Page}";
            }
        }
        public void PrevPgHandler(Book book)
        {
            if (book.CurrentPage > 1)
            {
                book.CurrentPage--;
                _page.Text = $"Page: {book.CurrentPage}/{book.Page}";
            }
        }


        public void GetBMHandler(Book book)
        {
            book.BMPage = book.CurrentPage;
            _bookmark.Text = $"Bookmark saved at page {book.BMPage}";
        }
        public void RemoveBMHandler(Book book)
        {
            book.BMPage = 0;
            _bookmark.Text = "No bookmark set";
        }
        public void SelectBMHandler(Book book)
        {
            book.BMPage = book.CurrentPage;
            _bookmark.Text = $"Bookmark saved at page {book.BMPage}";
        }

       
    }
}
