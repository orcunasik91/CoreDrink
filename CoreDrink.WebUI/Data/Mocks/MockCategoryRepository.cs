using CoreDrink.WebUI.Data.Interfaces;
using CoreDrink.WebUI.Data.Models;
using System.Collections.Generic;

namespace CoreDrink.WebUI.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories 
        { 
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Alkollü",Description = "Alkollü İçeçekler"},
                    new Category { CategoryName = "Alkolsüz",Description = "Alkolsüz İçeçekler"}
                };
            } 
        }
    }
}
