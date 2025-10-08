using ObjectOrientedPractics.Model;
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
        private List<Model.Customer> _customers = new List<Model.Customer>();
        private int _selectedIndex
        {
            get
            {
                return CustomersListBox.SelectedIndex;
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
            AddNewItem();
            ReloadItemsListBox();
        }

        public void CustomersRemoveButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedItem();
            ReloadItemsListBox();
        }

        public void CustomersGenerateButton_Click(object sender, EventArgs e)
        {
            foreach (Model.Customer item in Services.CustomerFabric.Generate())
            {
                _customers.Add(item);
            }

            ReloadItemsListBox();
            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        #endregion

        #region CustomersListBox functions
        private void ReloadItemsListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Model.Customer item in _customers)
            {
                CustomersListBox.Items.Add(item.ToString());
            }

            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        private void RemoveSelectedItem()
        {
            int index = _selectedIndex;

            if (index == -1 || index >= _customers.Count)
            {
                MessageBox.Show("Please, choose element from ListBox before.");
                return;
            }

            _customers.RemoveAt(index);
        }

        private void AddNewItem()
        {
            _customers.Add(new Model.Customer("Fullname", new Model.Address()));
            ReloadItemsListBox();
        }
        #endregion

        #region CustomersTab TextBoxes Listeners
        public void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadSelectedItemTextBoxes();
        }

        public void SelectedCustomerFullnameTextBox_TextChanged(object sender, EventArgs e)
        {
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

            UpdateListBoxItem();
        }
        #endregion

        #region SelectedIndexChange functions
        public void ReloadSelectedItemTextBoxes()
        {
            if (_selectedIndex != -1)
            {
                this.AddressControl.Address = _customers[_selectedIndex].Address;
                SelectedCustomerFullnameTextBox.Text = _customers[_selectedIndex].Fullname;
                SelectedCustomerIdTextBox.Text = _customers[_selectedIndex].Id.ToString();
            }
        }

        public void UpdateListBoxItem()
        {
            CustomersListBox.Items[_selectedIndex] = _customers[_selectedIndex].ToString();
        }
        #endregion
    }
}
