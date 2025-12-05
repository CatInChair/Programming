using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTabs : UserControl
    {
        
        private Services.DataTools.SortFunction _sortFunction;

        /// <summary>
        /// Список обрабатываемых товаров
        /// </summary>
        private List<Model.Item> _items;
        private List<Model.Item> _displayedItems;

        /// <summary>
        /// Абстракция индекса выбранного товара
        /// </summary>
        private int _selectedIndex
        {
            get
            {
                return ItemsListBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Открытые свойства приватного поля <see cref="_items">_items</see>
        /// </summary>
        public List<Model.Item> Items
        {
            get 
            { 
                return _items; 
            }
            set
            {
                _items = value;
                _displayedItems = Services.DataTools.Sort(value, SortByName);
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
            _RemoveSelectedItem();
            ReloadItemsListBox();
        }

        public void ItemsGenerateButton_Click(object sender, EventArgs e)
        {
            foreach (Model.Item item in Services.ItemFabric.Generate())
            {
                _items.Add(item);
            }

            Filter(_items);
            Resort(_displayedItems);
            ReloadItemsListBox();
        }

        public void ItemFindTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter(_items);
            Resort(_displayedItems);
            ReloadItemsListBox();
        }

        public void ItemOrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ItemOrderByComboBox.SelectedIndex)
            {
                case 0:
                {
                    _sortFunction = SortByName;
                    break;
                }
                case 1:
                {
                    _sortFunction = SortByCostAsc;
                    break;
                }
                case 2:
                {
                    _sortFunction = SortByCostDes;
                    break;
                }
            }

            Resort(_displayedItems);
            ReloadItemsListBox();
        }
        #endregion

        #region ItemsListBox functions
        /// <summary>
        /// Перезагружает все товары в <see cref="ItemsListBox">ItemsListBox</see> из <see cref="_items">_items</see>
        /// </summary>
        public void ReloadItemsListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Model.Item item in _displayedItems)
            {
                ItemsListBox.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// Удаляет товар по выбранному индексу
        /// </summary>
        private void _RemoveSelectedItem()
        {
            int index = _selectedIndex;

            if (index == -1 || index >= _displayedItems.Count) 
            {
                MessageBox.Show("Please, choose element from ListBox before.");
                return;
            }

            _items.Remove(_displayedItems[index]);
            _displayedItems.RemoveAt(index);

            ItemsListBox.SelectedIndex = index - 1;

            if (_items.Count == 0)
            {
                _ReloadSelectedItemTextBoxes();
            }
        }

        /// <summary>
        /// Добавляет пустой экземпляр товара
        /// </summary>
        private void AddNewItem()
        {
            _items.Add(new Model.Item("Name", "Information", 0, Model.Enumerators.Category.Custom));
            Filter(_items);
            Resort(_displayedItems);
            ReloadItemsListBox();
        }

        private bool SortByName(Model.Item now, Model.Item next)
        {
            if (now.Name.CompareTo(next.Name) > 0) return true;
            return false;
        }

        private bool SortByCostAsc(Model.Item now, Model.Item next)
        {
            if (now.Cost > next.Cost) return true;

            return false;
        }

        private bool SortByCostDes(Model.Item now, Model.Item next)
        {
            if (now.Cost < next.Cost) return true;

            return false;
        }

        private bool FilterByName(Model.Item item)
        {
            if (ItemFindTextBox.Text.Length > 0) return item.Name.Contains(ItemFindTextBox.Text);
            else return true;
        }

        private void Resort(List<Model.Item> items)
        {
            _displayedItems = Services.DataTools.Sort(items, _sortFunction);
        }

        private void Filter(List<Model.Item> items)
        {
            _displayedItems = Services.DataTools.Filter(items, FilterByName);
        }
        #endregion

        #region SelectedItem Values Listeners
        public void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadSelectedItemTextBoxes();
        }

        public void SelectedItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_displayedItems.Count == 0 || _selectedIndex == -1)
            {
                return;
            }

            string content = SelectedItemNameTextBox.Text;
            SelectedItemNameTextBox.BackColor = SystemColors.Window;

            if (content == _displayedItems[_selectedIndex].Name)
            {
                return;
            }

            try
            {
                _displayedItems[_selectedIndex].Name = content;
            }
            catch
            {
                SelectedItemNameTextBox.BackColor = Color.Red;
                MessageBox.Show("Item.Name length must be less than 200.");
                return;
            }

            _UpdateListBoxItem();
        }

        public void SelectedItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_displayedItems.Count == 0 || _selectedIndex == -1)
            {
                return;
            }

            double content;

            if (!Double.TryParse(SelectedItemCostTextBox.Text, out content))
            {
                SelectedItemCostTextBox.BackColor = Color.Red;
                MessageBox.Show("Item.Cost must be a real number!");
                return;
            }

            SelectedItemCostTextBox.BackColor = SystemColors.Window;

            if (content == _displayedItems[_selectedIndex].Cost)
            {
                return;
            }

            try
            {
                _displayedItems[_selectedIndex].Cost = content;
            }
            catch
            {
                SelectedItemCostTextBox.BackColor = Color.Red;
                MessageBox.Show("Item.Cost length must be more than 0 and less than 100000.");
                return;
            }

            _UpdateListBoxItem();
        }

        public void SelectedItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_displayedItems.Count == 0 || _selectedIndex == -1)
            {
                return;
            }

            string content = SelectedItemDescriptionTextBox.Text;
            SelectedItemDescriptionTextBox.BackColor = SystemColors.Window;

            if (content == _displayedItems[_selectedIndex].Info)
            {
                return;
            }

            try
            {
                _displayedItems[_selectedIndex].Info = content;
            }
            catch
            {
                SelectedItemDescriptionTextBox.BackColor = Color.Red;
                MessageBox.Show("Item.Description length must be less than 1000.");
            }
        }

        public void SelectedItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_displayedItems.Count == 0 || _selectedIndex == -1)
            {
                return;
            }

            Model.Enumerators.Category content = (Model.Enumerators.Category)SelectedItemCategoryComboBox.SelectedItem;

            if (content == _displayedItems[_selectedIndex].Category)
            {
                return;
            }

            _displayedItems[_selectedIndex].Category = content;
        }
        #endregion

        #region SelectedIndexChange functions
        /// <summary>
        /// Обновляет поля с данными о выбранном товаре
        /// </summary>
        public void _ReloadSelectedItemTextBoxes()
        {
            if (_selectedIndex != -1 && _displayedItems.Count > 0)
            {
                SelectedItemNameTextBox.Text = _displayedItems[_selectedIndex].Name;
                SelectedItemDescriptionTextBox.Text = _displayedItems[_selectedIndex].Info;
                SelectedItemCostTextBox.Text = _displayedItems[_selectedIndex].Cost.ToString();
                SelectedItemIdTextBox.Text = _displayedItems[_selectedIndex].Id.ToString();

                if (SelectedItemCategoryComboBox.Items.Count == 0) 
                {
                    foreach (Model.Enumerators.Category category in Enum.GetValues(typeof(Model.Enumerators.Category)))
                    {
                        SelectedItemCategoryComboBox.Items.Add(category);
                    }
                }

                SelectedItemCategoryComboBox.SelectedItem = _displayedItems[_selectedIndex].Category;
            }
            else
            {
                SelectedItemIdTextBox.Clear();
                SelectedItemNameTextBox.Clear();
                SelectedItemDescriptionTextBox.Clear();
                SelectedItemCategoryComboBox.Items.Clear();
                SelectedItemCategoryComboBox.Text = "";
                SelectedItemCostTextBox.Clear();
            }
        }

        /// <summary>
        /// Обновляет запись о товаре в <see cref="ItemsListBox">ItemsListBox</see>
        /// </summary>
        public void _UpdateListBoxItem()
        {
            ItemsListBox.Items[_selectedIndex] = _items[_selectedIndex].ToString();
        }
        #endregion
    }
}
