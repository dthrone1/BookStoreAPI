using BookStoreAPI.Core.Data;
using BookStoreAPI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Helper
{
    public class BookResourceMapper
    {
        public BookResource MapToResouce(Book book)
        {
            BookResource resource = new BookResource();
            resource.BookId = book.BookId;
            resource.Title = book.Title;
            resource.Description = book.Description;
            resource.PublishDate = book.PublishDate;
            resource.CoverImageURL = book.CoverImageURL;

            resource.Links = new List<Link>();
     
            resource.Links.Add(new Link { Rel = "self", Method = "GET" , Href = new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority)+"/api/Books/"+book.BookId)});
            return resource;
        }
    }
}