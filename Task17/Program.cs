using System;
using ClassLibrary;
namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddProduct(new Book()
            {
                Author = "dsds",
                Name = "dsdsds",
                Genre = "dsdsdds",
                Price=323
            });
            library.AddProduct(new Journal()
            {
                Company= "dsdsd",
                Name = "dsdsds",
                Price = 323
            });
            library.GetInfo();
        }
    }
}
