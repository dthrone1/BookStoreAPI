using BookStoreAPI.Core.Data;
using BookStoreAPI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.Core.Repository
{
    public interface IBooksRepository
    {
        BookCatalogResource GetBooks();
        BookCatalogResource GetBooks(int id);

        BookCatalogResource GetBooks(string FirstName, string LastName, string Category, string Total);

        Book Add(Book book);
        bool Delete(int bookId);
    }
}
