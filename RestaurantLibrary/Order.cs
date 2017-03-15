using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantLibrary
{
    public class Order
    {
        public decimal TotalPrice {
            get
            {
                var totalPrice = OrderItems.Sum(oi => oi.Price);
                return totalPrice;
            }
        }

        public List<MenuItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<MenuItem>();
        }

        public void AddItem(MenuItem menuItem)
        {
            if (menuItem != null)
                OrderItems.Add(menuItem);
        }

        public void AddMenu(Menu menu)
        {
            if (menu != null)
                OrderItems.AddRange(menu.MenuItems);
        }

        public void RemoveItem(MenuItem menuItem)
        {
            if (menuItem != null)
                OrderItems.Add(menuItem);
        }

        public void RemoveMenu(Menu menu)
        {
            if (menu != null)
            {
                foreach (var menuItem in menu.MenuItems)
                    OrderItems.Remove(menuItem);
            }
        }
    }
}
