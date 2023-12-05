using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Create an instance of the Book class
            Book book1 = new Book("Harry Porter", "Jk Rowling", 400);

            //Access and print the 'title' property of the book
            Console.WriteLine(book1.title);
            
            //freese console
            Console.ReadLine();
        }
    }
}
