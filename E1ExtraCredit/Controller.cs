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
        

        public Controller(LibraryModel m)
        {
            model = m;
        }

        public void GoToPgHandler(int page, Book book)
        {
            if(page <= book.Page && page >= 1)
            {
                book.CurrentPage = page;
                
            }
            
        }

        public void UpdateLibary()
        {
            Book Book4 = new Book()
            {
                Page = 832,
                Title = "The Shining ",
                Author = "Stephen King ",
                SerialNumber = "3768925630"
            };

            Book Book5 = new Book()
            {
                Page = 283,
                Title = "Hunger Games ",
                Author = "Suzanne Collins ",
                SerialNumber = "3567650928"
            };

            model.books.Add(Book4);
            model.books.Add(Book5);
        }

        public void SelectedBookHandler(int index)
        { 
            BookDetails detailsForm = new BookDetails(model,index, NextPgHandler, PrevPgHandler, RemoveBMHandler, SelectBMHandler, GoToPgHandler);
            
        }


        public void NextPgHandler(Book book)
        {
            if (book.CurrentPage < book.Page)
            {
                book.CurrentPage++;
                
            }
        }
        public void PrevPgHandler(Book book)
        {
            if (book.CurrentPage > 1)
            {
                book.CurrentPage--;
                
            }
        }


        
        public string RemoveBMHandler(Book book)
        {
            string si = SelectBMHandler(book);
            int inx = book.BookMarks.IndexOf(book.CurrentPage);
            if (book.BookMarks.Contains(book.CurrentPage) && book.CurrentPage == book.BookMarks[inx])
            { 

                book.BookMarks.RemoveAt(inx);

                StringBuilder sb = new StringBuilder();
                foreach (int s in book.BookMarks)
                {
                    sb.Append($"Bookmark saved at page {s}\n");
                }
                si = sb.ToString();
            }

            return si;
            
        }
        public string SelectBMHandler(Book book)
        {
            string si = "";
            if(book.BookMarks.Count < 5)
            {
                book.BMPage = book.CurrentPage;
                if(!book.BookMarks.Contains(book.CurrentPage))
                {
                    book.BookMarks.Add(book.BMPage);
                    StringBuilder sb = new StringBuilder();
                    foreach (int s in book.BookMarks)
                    {
                        sb.Append($"Bookmark saved at page {s}\n");
                    }
                    si = sb.ToString();

                   
                }

            }

                return si;


        }


    }
}
