using CoreDrink.WebUI.Data.Interfaces;
using CoreDrink.WebUI.Data.Models;
using CoreDrink.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDrink.WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IDrinkRepository drinkRepository, ShoppingCart shoppingCart)
        {
            _drinkRepository = drinkRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int drinkId)
        {
            Drink selectedDrink = _drinkRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if(selectedDrink != null)
            {
                _shoppingCart.AddToCart(selectedDrink,1);
            }
            return RedirectToAction(nameof(Index));
        }
        public RedirectToActionResult RemoveFromShoppingCart(int drinkId)
        {
            Drink selectedDrink = _drinkRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink != null)
            {
                _shoppingCart.RemoveFromCart(selectedDrink);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
