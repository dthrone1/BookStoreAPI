using BookStoreAPI.Core.Data;
using BookStoreAPI.Core.Repository;
using BookStoreAPI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreAPI.Controllers
{
    public class BooksController : ApiController
    {
        private IBooksRepository bookRepository = new BooksRepository();

        // GET api/books
        public IHttpActionResult Get()
        {
            BookCatalogResource book = new BookCatalogResource();

            string FirstName, LastName, Category, TotalRows;
            ProcessQueryString(out FirstName, out LastName, out Category, out TotalRows);

            if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName) && string.IsNullOrWhiteSpace(Category) && string.IsNullOrWhiteSpace(TotalRows))
            {
                book = bookRepository.GetBooks();
            }
            else
            {
                book = bookRepository.GetBooks(FirstName, LastName, Category, TotalRows);
            }

            if (book == null)
                return NotFound();

            return Ok(book);
        }



        // GET api/books/5
        public IHttpActionResult Get(int id)
        {
            var book = bookRepository.GetBooks(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }

        // POST api/books
        public HttpResponseMessage Post(Book book)
        {
            var bookResource = bookRepository.Add(book);
            var httpResponseMessage = Request.CreateResponse(HttpStatusCode.Created, bookResource);
            //httpResponseMessage.Headers.Location = bookResource.Self.Href;
            return httpResponseMessage;
        }

        // DELETE api/books/5
        public HttpResponseMessage Delete(int id)
        {
            //TO DO

            var foundAndDeleted = bookRepository.Delete(id);
            if (!foundAndDeleted)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Sorry - we could not find that book");
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        private void ProcessQueryString(out string FirstName, out string LastName, out string Category, out string TotalRows)
        {
            var allUrlKeyValues = ControllerContext.Request.GetQueryNameValuePairs();

            FirstName = allUrlKeyValues.SingleOrDefault(x => x.Key == "FirstName").Value;
            LastName = allUrlKeyValues.SingleOrDefault(x => x.Key == "LastName").Value;
            Category = allUrlKeyValues.SingleOrDefault(x => x.Key == "Category").Value;
            TotalRows = allUrlKeyValues.SingleOrDefault(x => x.Key == "Total").Value;
        }
    }
}
