using BookStoreAPI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreAPI.Controllers
{
    public class BookReviewController : ApiController
    {
        private IBookReviewRepository bookReviewRepository = new BookReviewRepository();

        // GET: api/BookReview
        public IHttpActionResult Get()
        {
            var author = bookReviewRepository.GetBookReview();

            if (author == null)
                return NotFound();

            return Ok(author);
        }

        // GET: api/BookReview/5
        public IHttpActionResult Get(int id)
        {
            var author = bookReviewRepository.GetBookReview(id);

            if (author == null)
                return NotFound();

            return Ok(author);
        }

        // POST: api/BookReview
        public void Post([FromBody]string value)
        {
            //TO DO
        }

        // PUT: api/BookReview/5
        public void Put(int id, [FromBody]string value)
        {
            //TO DO
        }

        // DELETE: api/BookReview/5
        public void Delete(int id)
        {
            //TO DO
        }
    }
}
