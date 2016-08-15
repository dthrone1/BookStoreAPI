using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class CategoryResource:LinkableResource
    {
        public int CategoryId { get; set; }
        public string Category{ get; set; }
    }
}