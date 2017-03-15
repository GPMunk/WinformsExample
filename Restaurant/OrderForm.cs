using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RL = RestaurantLibrary;

namespace Restaurant
{
    public partial class OrderForm : Form
    {
        #region LibraryInitialization

        private List<RL.Menu> _availableMenus = new List<RL.Menu>();
        private RL.Order _currentOrder = new RL.Order();

        private void InitializeAvailableMenus()
        {
            var friesMenuItem = new RL.MenuItem()
            {
                Title = "Fries",
                Price = 1.5m,
                Description = "These are some fries"
            };

            var turkishMenu = new RL.Menu
            {
                Name = "Döner Pizza",
                MenuType = RL.MenuType.Meat,
                MenuItems = new List<RL.MenuItem>()
                {
                    new RL.MenuItem()
                    {
                        Title = "Turkish Pizza",
                        Price = 2.5m,
                        Description = "This is a turkish pizza"
                    },
                    friesMenuItem
                }
            };

            var vegaMenu = new RL.Menu
            {
                Name = "Vega Burger",
                MenuType = RL.MenuType.Vegetarian,
                MenuItems = new List<RL.MenuItem>()
                {
                    new RL.MenuItem()
                    {
                        Title = "Vega Burger",
                        Price = 5.99m,
                        Description = "This is a vegetarian hamburger"
                    },
                    friesMenuItem
                }
            };

            var burgerMenu = new RL.Menu
            {
                Name = "Double Cheeseburger",
                MenuType = RL.MenuType.Meat,
                MenuItems = new List<RL.MenuItem>()
                {
                    new RL.MenuItem()
                    {
                        Title = "Double Cheeseburger",
                        Price = 4.99m,
                        Description = "This is a double cheeseburger"
                    },
                    friesMenuItem
                }
            };

            var visMenu = new RL.Menu
            {
                Name = "Grilled Salmon",
                MenuType = RL.MenuType.Fish,
                MenuItems = new List<RL.MenuItem>()
                {
                    new RL.MenuItem()
                    {
                        Title = "Grilled Salmon",
                        Price = 8.99m,
                        Description = "This is a grilled salmon"
                    },
                    friesMenuItem
                }
            };

            _availableMenus.Add(turkishMenu);
            _availableMenus.Add(vegaMenu);
            _availableMenus.Add(burgerMenu);
            _availableMenus.Add(visMenu);
        }

        #endregion

        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            _currentOrder.AddMenu(_availableMenus.FirstOrDefault(m => m.Name == cbMenus.Text));
            lstOrder.Items.Add(cbMenus.Text);
            RefreshTotalPrice();
        }

        private void btnRemoveMenu_Click(object sender, EventArgs e)
        {
            _currentOrder.RemoveMenu(_availableMenus.FirstOrDefault(m => m.Name == lstOrder.Text));
            lstOrder.Items.Remove(lstOrder.SelectedItem);
            RefreshTotalPrice();
        }

        private void btnClearMenus_Click(object sender, EventArgs e)
        {
            _currentOrder.OrderItems.Clear();
            lstOrder.Items.Clear();
            RefreshTotalPrice();
        }

        private void RefreshTotalPrice()
        {
             lblTotalPrice.Text = _currentOrder.TotalPrice.ToString("C");
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            InitializeAvailableMenus();

            //foreach (var availableMenu in _availableMenus)
            //{
            //    cbMenus.Items.Add(availableMenu);
            //}

            cbMenus.DataSource = _availableMenus;
            cbMenus.ValueMember = "Name";
        }

        private void cbMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox) sender).SelectedIndex != -1)
                btnAddMenu.Enabled = true;
            else
                btnAddMenu.Enabled = false;
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
                btnRemoveMenu.Enabled = true;
            else
                btnRemoveMenu.Enabled = false;
        }
    }
}
