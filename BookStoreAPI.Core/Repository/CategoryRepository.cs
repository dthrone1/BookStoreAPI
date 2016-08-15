using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreAPI.Core.Resources;
using BookStoreAPI.Core.Helper;
using BookStoreAPI.Core.Data;

namespace BookStoreAPI.Core.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private BookStoreEntities db = new BookStoreEntities();

        public CategoryCatalogResource GetCategory()
        {
            CategoryCatalogResource resource = new CategoryCatalogResource();
            try
            {
                var catagories = db.Categories.ToList();
                resource.Catalog = new List<CategoryResource>();
                foreach (var catagory in catagories)
                {
                    resource.Catalog.Add(new CategoryResourceMapper().MapToResouce(catagory));
                }

            }
            catch (Exception)
            {

                //TO Do Error Logging
            }

            return resource;
        }

        public CategoryCatalogResource GetCategory(int id)
        {
            CategoryCatalogResource resource = new CategoryCatalogResource();
            try
            {
                var catagories = db.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
                resource.Catalog = new List<CategoryResource>();                     
                resource.Catalog.Add(new CategoryResourceMapper().MapToResouce(catagories));
                

            }
            catch (Exception)
            {

                //TO Do Error Logging
            }

            return resource;
        }
    }
}