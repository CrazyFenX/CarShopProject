using Shop_Gosha_Dudar_.Data.Models;
using System.Collections.Generic;

namespace Shop_Gosha_Dudar_.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}