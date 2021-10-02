
using System.Collections.Generic;
using Shop_Gosha_Dudar_.Data.Models;

namespace Shop_Gosha_Dudar_.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getobjectCar(int carId);
    }
}