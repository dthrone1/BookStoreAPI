using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreAPI.Core.Data;
using BookStoreAPI.Core.Resources;
using BookStoreAPI.Core.Helper;
using System.Text;

namespace BookStoreAPI.Core.Repository
{
    public class BooksRepository : IBooksRepository
    {
        private BookStoreEntities db = new BookStoreEntities();

        public BookCatalogResource GetBooks()
        {
            BookCatalogResource resource = new BookCatalogResource();
            try
            {
                var books = db.Books.ToList();
                resource.Catalog = new List<BookResource>();
                foreach (var book in books)
                {
                    resource.Catalog.Add(new BookResourceMapper().MapToResouce(book));
                }

            }
            catch (Exception)
            {

                //TO Do Error Logging
            }
            
            return resource;
        }

        public BookCatalogResource GetBooks(int id)
        {
            BookCatalogResource resource = new BookCatalogResource();
            try
            {
                var book = db.Books.Where(x => x.BookId == id).FirstOrDefault();
                resource.Catalog = new List<BookResource>();
                resource.Catalog.Add(new BookResourceMapper().MapToResouce(book));

            }
            catch (Exception)
            {

               // TO Do Error Logging
            }            
            
            return resource;
        }

        //public BookCatalogResource GetBooks(string queryString)
        //{
        //    //Assuming QueryString will be received as stringParts[0] = FirstName, stringParts[1] = LastName,
        //    // stringParts[2] = Category, stringParts[3] = Total numbers requested

        //    BookCatalogResource resource = new BookCatalogResource();
        //    try
        //    {
        //        string[] stringParts = queryString.Split(',');

        //        var test = db.Books.SqlQuery("SELECT Top " + Convert.ToInt32(stringParts[3]) +
        //            " b.* FROM [BookStore].[dbo].[Books] b, [BookStore].[dbo].[AuthorBooks] ab, " +
        //            "[BookStore].[dbo].[Authors] a, [BookStore].[dbo].[Category] c Where b.BookId = ab.BookId " +
        //            " AND ab.AuthorId = a.AuthorId AND b.CategoryId = c.CategoryId AND c.Category = '"
        //            + stringParts[2] + "' AND a.FirstName = '" + stringParts[0] + "'AND a.LastName ='" + stringParts[1] + "'").ToList();



        //        resource.Catalog = new List<BookResource>();

        //        foreach (var book in test)
        //        {
        //            resource.Catalog.Add(new BookResourceMapper().MapToResouce(book));
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        //TO DO Error Logging
        //    }

        //    return resource;
        //}

        public Book Add(Book book)
        {
            book.BookId = GetNextId();
            db.Books.Add(book);
            return book;
        }

        public bool Delete(int bookId)
        {
            //TO DO
            throw new NotImplementedException();
        }

        static int GetNextId()
        {
            BookStoreEntities data = new BookStoreEntities();
            var books = data.Books.ToList();

            return books.OrderBy(b => b.BookId).Last().BookId + 1;
        }

        public BookCatalogResource GetBooks(string FirstName, string LastName, string Category, string Total)
        {           
            BookCatalogResource resource = new BookCatalogResource();
            try
            {  
                var test = db.Books.SqlQuery("SELECT Top " + Convert.ToInt32(Total) +
                    " b.* FROM [BookStore].[dbo].[Books] b, [BookStore].[dbo].[AuthorBooks] ab, " +
                    "[BookStore].[dbo].[Authors] a, [BookStore].[dbo].[Category] c Where b.BookId = ab.BookId " +
                    " AND ab.AuthorId = a.AuthorId AND b.CategoryId = c.CategoryId AND c.Category = '"
                    + Category + "' AND a.FirstName = '" + FirstName + "'AND a.LastName ='" + LastName + "'").ToList();

                resource.Catalog = new List<BookResource>();

                foreach (var book in test)
                {
                    resource.Catalog.Add(new BookResourceMapper().MapToResouce(book));
                }
            }
            catch (Exception)
            {

                //TO DO Error Logging
            }

            return resource;
        }
    }
}