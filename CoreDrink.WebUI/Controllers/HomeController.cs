using CoreDrink.WebUI.Data.Interfaces;
using CoreDrink.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreDrink.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }
        public ViewResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferredDrinks
            };
            return View(homeViewModel);
        }
    }
}
