using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class CategoryCatalogResource
    {
        public IList<CategoryResource> Catalog { get; set; }
    }
}