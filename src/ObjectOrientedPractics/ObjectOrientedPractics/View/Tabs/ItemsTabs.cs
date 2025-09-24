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
    public partial class ItemsTabs : UserControl
    {
        private List<Model.Item> _items = new List<Model.Item>();
        private int _selectedIndex 
        { 
            get
            {
                return ItemsListBox.SelectedIndex;
            }
        }

        public ItemsTabs()
        {
            InitializeComponent();
            InitializeListeners();
        }

        #region ItemsTabButtons Listeners

        public void ItemsAddButton_Click(object sender, EventArgs e)
        {
            AddNewItem();
            ReloadItemsListBox();
        }

        public void ItemsRemoveButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedItem();
            ReloadItemsListBox();
        }

        public void ItemsGenerateButton_Click(object sender, EventArgs e)
        {
            foreach (Model.Item item in Services.ItemFabric.Generate())
            {
                _items.Add(item);
            }

            ReloadItemsListBox();
            ItemsListBox.SelectedIndex = _items.Count - 1;
        }

        #endregion

        #region ItemsListBox functions
        private void ReloadItemsListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Model.Item item in _items)
            {
                ItemsListBox.Items.Add(item.ToString());
            }

            ItemsListBox.SelectedIndex = _items.Count - 1;
        }

        private void RemoveSelectedItem()
        {
            int index = _selectedIndex;

            if (index == -1 || index >= _items.Count) 
            {
                MessageBox.Show("Please, choose element from ListBox before.");
                return;
            }

            _items.RemoveAt(index);
        }

        private void AddNewItem()
        {
            _items.Add(new Model.Item("Name", "Information", 0));
            ReloadItemsListBox();
        }
        #endregion

        #region ItemsTab TextBoxes Listeners
        public void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadSelectedItemTextBoxes();
        }

        public void SelectedItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string content = SelectedItemNameTextBox.Text;
            SelectedItemNameTextBox.BackColor = SystemColors.Window;

            if (content == _items[_selectedIndex].Name)
            {
                return;
            }

            try
            {
                _items[_selectedIndex].Name = content;
            }
            catch
            {
                SelectedItemNameTextBox.BackColor = Color.Red;
                MessageBox.Show("Item.Name length must be less than 200.");
                return;
            }

            UpdateListBoxItem();
        }

        public void SelectedItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            double content;

            if (!Double.TryParse(SelectedItemCostTextBox.Text, out content))
            {
                SelectedItemCostTextBox.BackColor = Color.Red;
                MessageBox.Show("Item.Cost must be a real number!");
                return;
            }

            SelectedItemCostTextBox.BackColor = SystemColors.Window;

            if (content == _items[_selectedIndex].Cost)
            {
                return;
            }

            try
            {
                _items[_selectedIndex].Cost = content;
            }
            catch
            {
                SelectedItemCostTextBox.BackColor = Color.Red;
                MessageBox.Show("Item.Cost length must be more than 0 and less than 100000.");
                return;
            }

            UpdateListBoxItem();
        }

        public void SelectedItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            string content = SelectedItemDescriptionTextBox.Text;
            SelectedItemDescriptionTextBox.BackColor = SystemColors.Window;

            if (content == _items[_selectedIndex].Info)
            {
                return;
            }

            try
            {
                _items[_selectedIndex].Info = content;
            }
            catch
            {
                SelectedItemDescriptionTextBox.BackColor = Color.Red;
                MessageBox.Show("Item.Description length must be less than 1000.");
            }
        }
        #endregion

        #region SelectedIndexChange functions
        public void ReloadSelectedItemTextBoxes()
        {
            if (_selectedIndex != -1)
            {
                SelectedItemNameTextBox.Text = _items[_selectedIndex].Name;
                SelectedItemDescriptionTextBox.Text = _items[_selectedIndex].Info;
                SelectedItemCostTextBox.Text = _items[_selectedIndex].Cost.ToString();
                SelectedItemIdTextBox.Text = _items[_selectedIndex].Id.ToString();
            }
        }

        public void UpdateListBoxItem()
        {
            ItemsListBox.Items[_selectedIndex] = _items[_selectedIndex].ToString();
        }
        #endregion
    }
}
