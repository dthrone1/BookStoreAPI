using BookStoreAPI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreAPI.Controllers
{
    public class CategoriesController : ApiController
    {
        private ICategoryRepository categoryRepository = new CategoryRepository();

        // GET: api/Categories
        public IHttpActionResult Get()
        {
            var author = categoryRepository.GetCategory();

            if (author == null)
                return NotFound();

            return Ok(author);
        }

        // GET: api/Categories/5
        public IHttpActionResult Get(int id)
        {
            var author = categoryRepository.GetCategory(id);

            if (author == null)
                return NotFound();

            return Ok(author);
        }

        // POST: api/Categories
        public void Post([FromBody]string value)
        {
            //To Do
        }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]string value)
        {
            //TO DO
        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {
            //TO DO
        }
    }
}
