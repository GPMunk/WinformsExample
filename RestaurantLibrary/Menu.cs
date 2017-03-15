using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantLibrary
{
    public enum MenuType
    {
        Vegetarian,
        Meat,
        Fish
    }

    public class Menu
    {
        public string Name { get; set; }

        public List<MenuItem> MenuItems { get; set; }

        public decimal Price
        {
            get
            {
                var price = MenuItems.Sum(mi => mi.Price);
                return price;
            }
        }

        public MenuType MenuType { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }
    }
}
