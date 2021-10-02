 using Microsoft.AspNetCore.Mvc;
using Shop_Gosha_Dudar_.Data.Interfaces;
using Shop_Gosha_Dudar_.ViewModels;

namespace Shop_Gosha_Dudar_.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _carsCategory = iCarsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страницы с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
