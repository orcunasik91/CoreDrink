using CoreDrink.WebUI.Data.Models;
using System.Collections.Generic;

namespace CoreDrink.WebUI.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> PreferredDrinks { get; set; }
    }
}
