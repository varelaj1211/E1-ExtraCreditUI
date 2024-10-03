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
                Page = 678,
                Title = "Winnie-The-Pooh ",
                Author = "A. A. Mine ",
                SerialNumber = "3897259723"
            };
            Book Book2 = new Book()
            {
                Page = 1252,
                Title = "The Maze Runner ",
                Author = "James Straub ",
                SerialNumber = "8265473821"
            };
            Book Book3 = new Book()
            {
                Page = 574,
                Title = "50 Shades of Grey ",
                Author = "E. L. James ",
                SerialNumber = "7483987265"
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
                if(b.SerialNumber == SerialNum)
                {
                    books.Remove(b); 
                    break ;
                }
            }
        }

    }
}
