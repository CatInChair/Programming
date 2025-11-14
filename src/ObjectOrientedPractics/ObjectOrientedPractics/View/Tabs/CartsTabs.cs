using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTabs : UserControl
    {
        /// <summary>
        /// Список пользователей
        /// </summary>
        public List<Model.Customer> Customers;
        /// <summary>
        /// Список товаров
        /// </summary>
        public List<Model.Item> Items = new List<Model.Item>();

        /// <summary>
        /// Текущий выбранный пользователь
        /// </summary>
        private Model.Customer _currentCustomer;
        /// <summary>
        /// Абстракция индекса выбранного пользователя
        /// </summary>
        private int _selectedIndexCustomer
        {
            get
            {
                return CartCustomerComboBox.SelectedIndex;
            }
        }
        /// <summary>
        /// Абстракция индекса выбранного товара
        /// </summary>
        private int _selectedIndexItem
        {
            get
            {
                return CartItemsListBox.SelectedIndex;
            }
        }
        /// <summary>
        /// Абстракция индекса выбранного в тележке товара
        /// </summary>
        private int _selectedIndexCartItem
        {
            get
            {
                return CartListBox.SelectedIndex;
            }
        }


        public CartsTabs()
        {
            InitializeComponent();
            InitializeListeners();
        }

        #region Functions
        /// <summary>
        /// Перезагружает данные на странице
        /// </summary>
        public void LoadPage()
        {
            _LoadItems();
            _LoadCustomers();

        }
        /// <summary>
        /// Загружает список товаров
        /// </summary>
        private void _LoadItems()
        {
            CartItemsListBox.Items.Clear();

            foreach (Model.Item item in Items)
            {
                CartItemsListBox.Items.Add(item.ToString());
            }
        }
        /// <summary>
        /// Загружает список пользователей
        /// </summary>
        private void _LoadCustomers()
        {
            CartCustomerComboBox.Items.Clear();

            _currentCustomer = null;

            foreach (Model.Customer customer in Customers)
            {
                CartCustomerComboBox.Items.Add(customer.ToString());
            }

            CartListBox.Items.Clear();
        }
        /// <summary>
        /// Вывод стоимости корзины
        /// </summary>
        private void _CalculateCost()
        {
            CartAmountInfoLabel.Text = _currentCustomer.Cart.Amount.ToString() + "$";
        }
        /// <summary>
        /// Загружает список товаров в корзине
        /// </summary>
        private void _LoadCartItems()
        {
            CartListBox.Items.Clear();

            foreach (Model.Item item in _currentCustomer.Cart.Items) 
            {
                CartListBox.Items.Add(item.ToString());
            }

            _CalculateCost();
        }
        #endregion

        #region Listeners
        public void CartCustomersComboBox_SelectedIndexChanged(object args, EventArgs e)
        {
            if (_selectedIndexCustomer == -1)
            {
                return;
            }

            CartListBox.Items.Clear();
            _currentCustomer = Customers[_selectedIndexCustomer];

            _LoadCartItems();
        }

        public void CartAddItemButton_Click(object args, EventArgs e)
        {
            if (_selectedIndexItem  < 0 || _selectedIndexItem >= Items.Count)
            {
                MessageBox.Show("Change Item from left ListBox before.");
                return;
            }

            if (_selectedIndexCustomer < 0 || _selectedIndexCustomer >= Customers.Count)
            {
                MessageBox.Show("Change Customer from ComboBox before.");
                return;
            }

            Model.Item item = Items[_selectedIndexItem];

            _currentCustomer.Cart.Items.Add(item);
            _LoadCartItems();
        }

        public void CartRemoveItemButton_Click(object args, EventArgs e)
        {
            if (_selectedIndexCartItem < 0 || _selectedIndexCartItem >= _currentCustomer.Cart.Items.Count)
            {
                MessageBox.Show("Change Item from right ListBox before.");
                return;
            }

            if (_selectedIndexCustomer < 0 || _selectedIndexCustomer >= Customers.Count)
            {
                MessageBox.Show("Change Customer from ComboBox before.");
                return;
            }

            _currentCustomer.Cart.Items.RemoveAt(_selectedIndexCartItem);
            _LoadCartItems();
        }

        public void CartClearButton_Click(Object args, EventArgs e)
        {
            if (_selectedIndexCustomer < 0 || _selectedIndexCustomer >= Customers.Count)
            {
                MessageBox.Show("Change Customer from ComboBox before.");
                return;
            }

            _currentCustomer.Cart.Items.Clear();
            _LoadCartItems();
        }

        public void CartCreateOrderButton_Click(object args, EventArgs e)
        {
            if (_selectedIndexCustomer < 0 || _selectedIndexCustomer >= Customers.Count)
            {
                MessageBox.Show("Change Customer from ComboBox before.");
                return;
            }

            if (_currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Add some items in cart before.");
                return;
            }

            if (_currentCustomer.IsPriority)
            {
                _currentCustomer.Orders.Add(new Model.PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart.Clone()));
            }
            else
            {
                _currentCustomer.Orders.Add(new Model.Order(_currentCustomer.Address, _currentCustomer.Cart.Clone()));
            }
            _currentCustomer.Cart.Items.Clear();
            _LoadCartItems();
        }
        #endregion
    }
}
