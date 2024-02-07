using BackEnd.Models;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;
        public bool AddCategory(CategoryModel category)
        {
            Category entity = new Category
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description
            };

            _unidadDeTrabajo._categoryDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        public bool DeleteCategory(CategoryModel category)
        {
            throw new NotImplementedException();
        }

        public ICategoryService GetById(int id)
        {
            var entity = _unidadDeTrabajo._categoryDAL.Get(id);
            CategoryModel categoryModel = new CategoryModel
            {
                CategoryId = entity.CategoryId,
                CategoryName = entity.CategoryName,
                Description = entity.Description
            };
            return categoryModel;
        }

        public IEnumerable<CategoryModel> GetCategories()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(CategoryModel category)
        {
            throw new NotImplementedException();
        }
    }
}
