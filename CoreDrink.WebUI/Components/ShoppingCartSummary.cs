using CoreDrink.WebUI.Data.Models;
using CoreDrink.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDrink.WebUI.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            //var items = _shoppingCart.GetShoppingCartItems();
            var items = new List<ShoppingCartItem>()
            {
                new ShoppingCartItem(),
                new ShoppingCartItem()
            };
            _shoppingCart.ShoppingCartItems = items;
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
