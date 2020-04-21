using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice
{
    class Book
    {
        public string BookName { set; get; }
        public string BookCode { set; get; }
        public string BookAuthor { set; get; }
        public int BookStock { set; get; }

        public Book(string bName, string bCode, string bAuthor, int bStock)
        {
            BookName = bName;
            BookCode = bCode;
            BookAuthor = bAuthor;
            BookStock = bStock;
        }

      
    }
}
