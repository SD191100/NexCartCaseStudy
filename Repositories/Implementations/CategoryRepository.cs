using NexCart.Data;
using NexCart.Models;
using NexCart.Repositories.Interfaces;

namespace NexCart.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NexCartDBContext _context;

        public CategoryRepository(NexCartDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = GetCategoryById(categoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}

