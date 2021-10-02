using System.Collections.Generic;
using Shop_Gosha_Dudar_.Data.Models;

namespace Shop_Gosha_Dudar_.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
