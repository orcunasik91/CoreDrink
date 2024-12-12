using CoreDrink.WebUI.Data.Models;
using System.Collections.Generic;

namespace CoreDrink.WebUI.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> PreferredDrinks { get; set; }
        Drink GetDrinkById(int drinkId);
    }
}
