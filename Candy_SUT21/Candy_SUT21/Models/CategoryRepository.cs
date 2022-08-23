namespace Candy_SUT21.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category> 
        {
            new Category { CategoryID = 1, CategoryName = "Hard Candy", CategoryDescription = "Awesome Hard Candy"},
            new Category { CategoryID = 1, CategoryName = "Chocolate Candy", CategoryDescription = "Awesome Chocolate Candy"},
            new Category { CategoryID = 1, CategoryName = "Fruit Candy", CategoryDescription = "Awesome Fruit Candy"},
        };
    }
}
