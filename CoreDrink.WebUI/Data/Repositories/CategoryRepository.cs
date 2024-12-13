using CoreDrink.WebUI.Data.Interfaces;
using CoreDrink.WebUI.Data.Models;
using System.Collections.Generic;

namespace CoreDrink.WebUI.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
