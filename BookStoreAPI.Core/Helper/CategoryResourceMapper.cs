using BookStoreAPI.Core.Data;
using BookStoreAPI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Helper
{
    public class CategoryResourceMapper
    {
        public CategoryResource MapToResouce(Category category)
        {
            CategoryResource resource = new CategoryResource();
            resource.CategoryId = category.CategoryId;
            resource.Category = category.Category1;
           
            resource.Links = new List<Link>();

            resource.Links.Add(new Link { Rel = "self", Method = "GET", Href = new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/api/Category/" + category.CategoryId) });
            return resource;
        }
    }
}