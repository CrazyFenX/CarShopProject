using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Gosha_Dudar_.Data.Interfaces;
using Shop_Gosha_Dudar_.Data.Models;

namespace Shop_Gosha_Dudar_.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get 
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category { categoryName = "Классические", desc = "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
