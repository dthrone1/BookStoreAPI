using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreAPI.Core.Resources;
using BookStoreAPI.Core.Data;
using BookStoreAPI.Core.Helper;

namespace BookStoreAPI.Core.Repository
{
    public class AuthorRepository : IAuthorsRepository
    {
        private BookStoreEntities db = new BookStoreEntities();

        public AuthorCatalogResource GetAuthors()
        {
            AuthorCatalogResource resource = new AuthorCatalogResource();
            try
            {
                var authors = db.Authors.ToList();
                resource.Catalog = new List<AuthorResource>();
                foreach (var book in authors)
                {
                    resource.Catalog.Add(new AuthorResourceMapper().MapToResouce(book));
                }

            }
            catch (Exception)
            {

                //TO Do Error Logging
            }

            return resource;
        }

        public AuthorCatalogResource GetAuthors(int id)
        {
            AuthorCatalogResource resource = new AuthorCatalogResource();
            try
            {
                var author = db.Authors.Where(x => x.AuthorId == id).FirstOrDefault();
                resource.Catalog = new List<AuthorResource>();
                resource.Catalog.Add(new AuthorResourceMapper().MapToResouce(author));

            }
            catch (Exception)
            {

                // TO Do Error Logging
            }

            return resource;
        }
    }
}