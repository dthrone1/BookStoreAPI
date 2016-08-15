using BookStoreAPI.Core.Data;
using BookStoreAPI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Helper
{
    public class BookReviewResourceMapper
    {
        public BookReviewResource MapToResouce(BookReview bookReview)
        {
            BookReviewResource resource = new BookReviewResource();
            resource.BookReviewId = bookReview.ReviewId;
            resource.ReviewText = bookReview.ReviewText;
            resource.ReviewerName = bookReview.ReviewerName;
            resource.Rating = bookReview.Rating;
            resource.PublishDate = bookReview.PublishDate;

            resource.Links = new List<Link>();

            resource.Links.Add(new Link { Rel = "self", Method = "GET", Href = new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/api/BookReview/" + bookReview.ReviewId) });
            return resource;
        }
    }
}