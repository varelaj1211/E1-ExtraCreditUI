using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1ExtraCredit
{
    public class LibraryModel
    {
        public List<Book> books;


        public LibraryModel() {
            books = new List<Book>();
            Book Book1 = new Book()
            {
                _page = 678,
                _title = "Winnie-The-Pooh ",
                _author = "A. A. Mine ",
                _serialNumber = "3897259723"
            };
            Book Book2 = new Book()
            {
                _page = 1252,
                _title = "The Maze Runner ",
                _author = "James Straub ",
                _serialNumber = "8265473821"
            };
            Book Book3 = new Book()
            {
                _page = 574,
                _title = "50 Shades of Grey ",
                _author = "E. L. James ",
                _serialNumber = "7483987265"
            };

        
            books.Add(Book1);
            books.Add(Book2);
            books.Add(Book3);
           
        }


        //Sample Books
        public void AddBook(Book b)
        {
            books.Add(b);
        }
        public void RemoveBook(string SerialNum)
        {
            foreach(Book b in books)
            {
                if(b._serialNumber == SerialNum)
                {
                    books.Remove(b); 
                    break ;
                }
            }
        }

    }
}
