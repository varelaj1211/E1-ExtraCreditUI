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
        private UpdateViewState observer;
        private UpdateLibrary libraryObserver;
        private Status state;

        public Controller(LibraryModel m)
        {
            model = m;
        }

        public void RegisterDetailsObserver(UpdateViewState o)
        {
            observer = o;
        }

        public void RegisterLibaryObserver(UpdateLibrary ol)
        {
            libraryObserver = ol;
        }

        public void GoToPgHandler(int page, Book book)
        {
            if(page <= book.Page && page >= 1)
            {
                book.CurrentPage = page;
                state = Status.GoToPg;
                
            }
            observer(state);
        }




        public void SyncLibaryHandler(List<Book> books)
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

            books.Add(Book4);
            books.Add(Book5);
            state = Status.Sync;
            libraryObserver(state);
        }

        public void SelectedBookHandler(int index)
        { 
            BookDetails detailsForm = new BookDetails(model,index, NextPgHandler, PrevPgHandler, RemoveBMHandler, SelectBMHandler, GoToPgHandler);
            RegisterDetailsObserver(detailsForm.UpdateGameState);
            state = Status.SelectBook;
            libraryObserver(state);
            detailsForm.ShowDialog();

            
        }


        public void NextPgHandler(Book book)
        {
            if (book.CurrentPage < book.Page)
            {
                book.CurrentPage++;
                state = Status.NextPg;
                observer(state);
            }
            
        }
        public void PrevPgHandler(Book book)
        {
            if (book.CurrentPage > 1)
            {
                book.CurrentPage--;
                state = Status.PrevPg;
            }
            observer(state);
        }


        
        public void RemoveBMHandler(Book book, List<int> pagesList)
        {
            //string si = SelectBMHandler(book);
            int inx = book.BookMarks.IndexOf(book.CurrentPage);
            if (book.BookMarks.Contains(book.CurrentPage) && book.CurrentPage == book.BookMarks[inx])
            { 

                book.BookMarks.RemoveAt(inx);
                state = Status.RemoveBM;
                
            }
            observer(state);
            //return si;

        }
        public void SelectBMHandler(Book book, List<int> pagesList)
        {
            
            if(book.BookMarks.Count < 5)
            {
                book.BMPage = book.CurrentPage;
                if(!pagesList.Contains(book.CurrentPage))
                {
                    book.BookMarks.Add(book.BMPage);

                    state = Status.AddBM;
                }

            }

            observer(state);
        }


    }
}
