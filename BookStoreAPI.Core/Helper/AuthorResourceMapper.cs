using BookStoreAPI.Core.Data;
using BookStoreAPI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Helper
{
    public class AuthorResourceMapper
    {
        public AuthorResource MapToResouce(Author author)
        {
            AuthorResource resource = new AuthorResource();
            resource.AuthorId = author.AuthorId;
            resource.FirstName = author.FirstName;
            resource.LastName = author.LastName;
            resource.HeadShotImageURL = author.HeadShorImageURL;

            resource.Links = new List<Link>();

            resource.Links.Add(new Link { Rel = "self", Method = "GET", Href = new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/api/Authors/" + author.AuthorId) });
            return resource;
        }
    }
}