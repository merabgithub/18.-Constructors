using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    // Define the Book class
    internal class Book
    {
        // Classes are for creating more complex data types, eg a book can have a title,
        // and pages which are different data types combined

       
          // Properties of the Book class
            public string title;
            public string author;
            public int pages;

            //this method below is called a constructor, the Book class that takes three parameters
            public Book(string aTitle, string aAuthor, int aPages)
            { 
                title = aTitle;
                author = aAuthor;
                pages = aPages;

            }
        
    }
}
