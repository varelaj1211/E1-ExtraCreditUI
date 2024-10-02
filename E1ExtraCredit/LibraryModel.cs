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

            Book Book4 = new Book()
            {
                _page = 832,
                _title = "The Shining ",
                _author = "Stephen King ",
                _serialNumber = "3768925630"
            };

            Book Book5 = new Book()
            {
                _page = 283,
                _title = "Hunger Games ",
                _author = "Suzanne Collins ",
                _serialNumber = "3567650928"
            };
            books!.Add(Book1);
            books.Add(Book2);
            books.Add(Book3);
            books.Add(Book4);
            books.Add(Book5);
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


    public class Book
    {
        public int _page { get; set; }
        public string _title { get; set; }

        public string _author { get; set; }

        public string _serialNumber;

        public Book() 
        {
        }   
    }

    //testing same file different spot



}
