using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class BookReviewCatalogResource:LinkableResource
    {
        public IList<BookReviewResource> Catalog { get; set; }
    }
}