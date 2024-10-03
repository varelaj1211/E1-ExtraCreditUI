using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1ExtraCredit
{
    public class Book
    {
        public int Page { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public string SerialNumber;

        public int CurrentPage { get; set; } = 1;

        public int BMPage { get; set; } = 1;

        

        public Book() { }
        
    }
}
