using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class Link
    {
        public Uri Href { get; set; }
        public string Rel { get; set; }
        //public string Name { get; set; }
        public string Method { get; set; }
    }
}