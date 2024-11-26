using NexCart.Models;

namespace NexCart.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
    }
}
