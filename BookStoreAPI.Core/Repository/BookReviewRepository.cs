using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreAPI.Core.Resources;
using BookStoreAPI.Core.Helper;
using BookStoreAPI.Core.Data;

namespace BookStoreAPI.Core.Repository
{
    public class BookReviewRepository : IBookReviewRepository
    {
        private BookStoreEntities db = new BookStoreEntities();

        public BookReviewCatalogResource GetBookReview()
        {
            BookReviewCatalogResource resource = new BookReviewCatalogResource();
            try
            {
                var bookReviews = db.BookReviews.ToList();
                resource.Catalog = new List<BookReviewResource>();
                foreach (var bookReview in bookReviews)
                {
                    resource.Catalog.Add(new BookReviewResourceMapper().MapToResouce(bookReview));
                }

            }
            catch (Exception)
            {

                //TO Do Error Logging
            }

            return resource;
        }

        public BookReviewCatalogResource GetBookReview(int id)
        {
            BookReviewCatalogResource resource = new BookReviewCatalogResource();
            try
            {
                var bookReviews = db.BookReviews.Where(x => x.ReviewId == id).FirstOrDefault();
                resource.Catalog = new List<BookReviewResource>();           
                resource.Catalog.Add(new BookReviewResourceMapper().MapToResouce(bookReviews));
              
            }
            catch (Exception)
            {

                //TO Do Error Logging
            }

            return resource;
        }
    }
}