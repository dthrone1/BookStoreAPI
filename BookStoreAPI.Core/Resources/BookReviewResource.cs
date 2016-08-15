using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Core.Resources
{
    public class BookReviewResource:LinkableResource
    {
        public int BookReviewId { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewText { get; set; }
        public string Rating { get; set; }
        public DateTime? PublishDate { get; set; }

    }
}