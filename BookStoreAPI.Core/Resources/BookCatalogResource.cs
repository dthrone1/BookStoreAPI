using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class BookCatalogResource:LinkableResource
    {
        public IList<BookResource> Catalog { get; set; }
    }
}