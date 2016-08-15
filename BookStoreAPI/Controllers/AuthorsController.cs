using BookStoreAPI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreAPI.Controllers
{
    public class AuthorsController : ApiController
    {
        private IAuthorsRepository authorRepository = new AuthorRepository();

        // GET: api/Authors
        public IHttpActionResult Get()
        {
            var author = authorRepository.GetAuthors();

            if (author == null)
                return NotFound();

            return Ok(author);
        }

        // GET: api/Authors/5
        public IHttpActionResult Get(int id)
        {
            var author = authorRepository.GetAuthors(id);

            if (author == null)
                return NotFound();

            return Ok(author);
        }

        // POST: api/Authors
        public void Post([FromBody]string value)
        {
            //To DO
        }

        // PUT: api/Authors/5
        public void Put(int id, [FromBody]string value)
        {
            //To DO
        }

        // DELETE: api/Authors/5
        public void Delete(int id)
        {
            //To DO
        }
    }
}
