using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class LinkableResource
    {
        public Link Self { get; set; }
        public List<Link> Links { get; set; }
    }
}