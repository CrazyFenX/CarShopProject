using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Gosha_Dudar_.Data.Interfaces;
using Shop_Gosha_Dudar_.Data.Models;

namespace Shop_Gosha_Dudar_.Data.mocks
{
    public class MockCars : IAllCars
    {
        public readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "Tesla",
                        shortDesc = "",
                        longDesc = "",
                        img = "",
                        price = 45000, 
                        isFavorite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getobjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
