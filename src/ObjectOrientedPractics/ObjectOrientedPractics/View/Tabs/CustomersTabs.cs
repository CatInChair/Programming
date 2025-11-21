using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
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
    public partial class CustomersTabs : UserControl
    {
        /// <summary>
        /// Список пользователей
        /// </summary>
        private List<Model.Customer> _customers;

        /// <summary>
        /// Абстракция индекса текущего выбранного пользователя
        /// </summary>
        private int _selectedIndex
        {
            get
            {
                return CustomersListBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Открытые свойства приватного поля <see cref="_customers">_customers</see>
        /// </summary>
        public List<Model.Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        public CustomersTabs()
        {
            InitializeComponent();
            InitializeListeners();
        }

        #region CustomersTabButtons Listeners
        public void CustomersAddButton_Click(object sender, EventArgs e)
        {
            _AddNewItem();
            ReloadCustomersListBox();
        }

        public void CustomersRemoveButton_Click(object sender, EventArgs e)
        {
            _RemoveSelectedCustomer();
            ReloadCustomersListBox();
        }

        public void CustomersGenerateButton_Click(object sender, EventArgs e)
        {
            foreach (Model.Customer item in Services.CustomerFabric.Generate())
            {
                _customers.Add(item);
            }

            ReloadCustomersListBox();
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
        }

        #endregion

        #region CustomersListBox functions
        /// <summary>
        /// Перезагружает список пользователей
        /// </summary>
        public void ReloadCustomersListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Model.Customer item in _customers)
            {
                CustomersListBox.Items.Add(item.ToString());
            }

            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        /// <summary>
        /// Удаляет выбранного пользователя
        /// </summary>
        private void _RemoveSelectedCustomer()
        {
            int index = _selectedIndex;

            if (index == -1 || index >= _customers.Count)
            {
                MessageBox.Show("Please, choose element from ListBox before.");
                return;
            }

            _customers.RemoveAt(index);
        }

        /// <summary>
        /// Создает нового пользователя
        /// </summary>
        private void _AddNewItem()
        {
            _customers.Add(new Model.Customer("Fullname", new Model.Address()));
            ReloadCustomersListBox();
        }
        #endregion

        #region CurrentCustomer Listeners
        public void SelectedCustomerIsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedIndex == -1)
            {
                MessageBox.Show("Select customer from left list before.");
                return;
            }

            if (Customers[_selectedIndex].IsPriority == SelectedCustomerIsPriorityCheckBox.Checked) return;

            Customers[_selectedIndex].IsPriority = SelectedCustomerIsPriorityCheckBox.Checked;
        }

        public void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadSelectedItemTextBoxes();
        }

        public void SelectedCustomerFullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedIndex == -1)
            {
                MessageBox.Show("Select customer from left list before.");
                return;
            }

            string content = SelectedCustomerFullnameTextBox.Text;
            SelectedCustomerFullnameTextBox.BackColor = SystemColors.Window;

            if (content == _customers[_selectedIndex].Fullname)
            {
                return;
            }

            try
            {
                _customers[_selectedIndex].Fullname = content;
            }
            catch
            {
                SelectedCustomerFullnameTextBox.BackColor = Color.Red;
                MessageBox.Show("Customer.Fullname length must be less than 200.");
                return;
            }

            _UpdateListBoxItem();
        }
        #endregion

        #region CurrentCustomer functions
        /// <summary>
        /// Обновляет данные о выбранном пользователе
        /// </summary>
        public void ReloadSelectedItemTextBoxes()
        {
            CustomerDiscountsListBox.Items.Clear();

            if (_selectedIndex != -1)
            {
                SelectedCustomerIdTextBox.Text = _customers[_selectedIndex].Id.ToString();
                this.AddressControl.Address = _customers[_selectedIndex].Address;
                SelectedCustomerFullnameTextBox.Text = _customers[_selectedIndex].Fullname;
                SelectedCustomerIdTextBox.Text = _customers[_selectedIndex].Id.ToString();
                SelectedCustomerIsPriorityCheckBox.Checked = _customers[_selectedIndex].IsPriority;
                foreach (IDiscount discount in _customers[_selectedIndex].Discounts)
                {
                    CustomerDiscountsListBox.Items.Add(discount.Info);
                }
            }
            else
            {
                SelectedCustomerIdTextBox.Text = "";
                this.AddressControl.Address = new Address();
                SelectedCustomerFullnameTextBox.Text = "";
                SelectedCustomerIdTextBox.Text = "";
                SelectedCustomerIsPriorityCheckBox.Checked = false;
            }
        }

        /// <summary>
        /// Обновляет данные о выбранном пользователе внутри <see cref="CustomersListBox">ListBox'a</see>
        /// </summary>
        public void _UpdateListBoxItem()
        {
            CustomersListBox.Items[_selectedIndex] = _customers[_selectedIndex].ToString();
        }

        public void DiscountAddButton_Click(object sender, EventArgs e)
        {
            using (CategoryModal modal = new CategoryModal())
            {
                if (modal.ShowDialog(this)  == DialogResult.OK)
                {
                    _customers[_selectedIndex].Discounts.Add(new PercentDiscount(modal.Category));
                    ReloadSelectedItemTextBoxes();
                }
            }
        }

        public void DiscountRemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomerDiscountsListBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Choose discount from ListBox before.");
                return;
            }

            if (CustomerDiscountsListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Points discount can't be removed.");
                return;
            }

            _customers[_selectedIndex].Discounts.RemoveAt(CustomerDiscountsListBox.SelectedIndex);
            ReloadSelectedItemTextBoxes();
        }
        #endregion
    }
}
