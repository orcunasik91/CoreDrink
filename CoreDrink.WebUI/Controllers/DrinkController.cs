using CoreDrink.WebUI.Data.Interfaces;
using CoreDrink.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreDrink.WebUI.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }
        public ViewResult List()
        {
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = "İçecek Kategorisi";
            return View(vm);
        }
    }
}
