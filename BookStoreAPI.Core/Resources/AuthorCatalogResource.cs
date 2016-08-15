using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class AuthorCatalogResource:LinkableResource
    {
        public IList<AuthorResource> Catalog { get; set; }
    }
}