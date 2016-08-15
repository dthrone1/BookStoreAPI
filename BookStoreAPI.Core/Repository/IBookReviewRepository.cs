using BookStoreAPI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.Core.Repository
{
    public interface IBookReviewRepository
    {
        BookReviewCatalogResource GetBookReview();
        BookReviewCatalogResource GetBookReview(int id);
    }
}
