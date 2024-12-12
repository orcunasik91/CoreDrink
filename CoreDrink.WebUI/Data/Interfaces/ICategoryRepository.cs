using CoreDrink.WebUI.Data.Models;
using System.Collections.Generic;

namespace CoreDrink.WebUI.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
