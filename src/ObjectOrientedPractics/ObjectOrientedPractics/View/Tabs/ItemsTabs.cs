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

        /// <summary>
        /// Индекс выбранного на данный момент внутри ListBox товара
        /// </summary>
        private int _selectedIndex
        {
            get
            {
                return ItemsListBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Список обрабатываемых товаров
        /// </summary>
        public List<Model.Item> Items
        {
            get 
            { 
                return _items; 
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
            _ReloadItemsListBox();
        }

        public void ItemsRemoveButton_Click(object sender, EventArgs e)
        {
            _RemoveSelectedItem();
            _ReloadItemsListBox();
        }

        public void ItemsGenerateButton_Click(object sender, EventArgs e)
        {
            foreach (Model.Item item in Services.ItemFabric.Generate())
            {
                _items.Add(item);
            }

            _ReloadItemsListBox();
            ItemsListBox.SelectedIndex = _items.Count - 1;
        }
        #endregion

        #region ItemsListBox functions
        /// <summary>
        /// Перезагружает все товары в <see cref="ItemsListBox">ItemsListBox</see> из <see cref="_items">_items</see>
        /// </summary>
        private void _ReloadItemsListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Model.Item item in _items)
            {
                ItemsListBox.Items.Add(item.ToString());
            }

            ItemsListBox.SelectedIndex = _items.Count - 1;
        }

        /// <summary>
        /// Удаляет товар по выбранному индексу
        /// </summary>
        private void _RemoveSelectedItem()
        {
            int index = _selectedIndex;

            if (index == -1 || index >= _items.Count) 
            {
                MessageBox.Show("Please, choose element from ListBox before.");
                return;
            }

            _items.RemoveAt(index);

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
            _ReloadItemsListBox();
        }
        #endregion

        #region SelectedItem Values Listeners
        public void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadSelectedItemTextBoxes();
        }

        public void SelectedItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_items.Count == 0)
            {
                return;
            }

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

            _UpdateListBoxItem();
        }

        public void SelectedItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_items.Count == 0)
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

            _UpdateListBoxItem();
        }

        public void SelectedItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_items.Count == 0)
            {
                return;
            }

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

        public void SelectedItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_items.Count == 0)
            {
                return;
            }

            Model.Enumerators.Category content = (Model.Enumerators.Category)SelectedItemCategoryComboBox.SelectedItem;

            if (content == _items[_selectedIndex].Category)
            {
                return;
            }

            _items[_selectedIndex].Category = content;
        }
        #endregion

        #region SelectedIndexChange functions
        /// <summary>
        /// Обновляет поля с данными о выбранном товаре
        /// </summary>
        public void _ReloadSelectedItemTextBoxes()
        {
            if (_selectedIndex != -1 && _items.Count > 0)
            {
                SelectedItemNameTextBox.Text = _items[_selectedIndex].Name;
                SelectedItemDescriptionTextBox.Text = _items[_selectedIndex].Info;
                SelectedItemCostTextBox.Text = _items[_selectedIndex].Cost.ToString();
                SelectedItemIdTextBox.Text = _items[_selectedIndex].Id.ToString();

                if (SelectedItemCategoryComboBox.Items.Count == 0) 
                {
                    foreach (Model.Enumerators.Category category in Enum.GetValues(typeof(Model.Enumerators.Category)))
                    {
                        SelectedItemCategoryComboBox.Items.Add(category);
                    }
                }

                SelectedItemCategoryComboBox.SelectedItem = _items[_selectedIndex].Category;
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
