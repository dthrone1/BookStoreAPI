using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class BookResource : LinkableResource
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? PublishDate { get; set; }
        public string CoverImageURL { get; set; }
    }
}