
using System.Collections.Generic;

namespace Shop_Gosha_Dudar_.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public List<Car> cars { get; set; }
    }
}
