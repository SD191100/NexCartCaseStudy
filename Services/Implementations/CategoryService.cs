using NexCart.Models;
using NexCart.Repositories.Interfaces;
using NexCart.Services.Interfaces;

namespace NexCart.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _categoryRepository.GetCategoryById(categoryId);
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.UpdateCategory(category);
        }

        public void DeleteCategory(int categoryId)
        {
            _categoryRepository.DeleteCategory(categoryId);
        }
    }
}
