using CoreDrink.WebUI.Data.Models;
using System.Collections.Generic;

namespace CoreDrink.WebUI.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
