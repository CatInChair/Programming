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
    public partial class OrdersTabs : UserControl
    {
        /// <summary>
        /// Список клиентов
        /// </summary>
        public List<Model.Customer> Customers { get; set; }

        /// <summary>
        /// Список записей о заказах
        /// </summary>
        private BindingList<Model.Orders.OrderEntry> _orders = new BindingList<Model.Orders.OrderEntry>();

        /// <summary>
        /// Абстракция текущего выбранного заказа
        /// </summary>
        private Model.Orders.OrderEntry _order
        {
            get
            {
                return _orders.Where((Model.Orders.OrderEntry en) => en.Id.ToString() == OrdersDataGridView.CurrentRow.Cells["IdColumn"].Value.ToString()).First();
            }
        }

        public OrdersTabs()
        {
            InitializeComponent();
            InitializeListeners();
            OrdersDataGridView.DataSource = _orders;
        }

        #region OrdersTabs functions
        /// <summary>
        /// Перезагружает данные на странице
        /// </summary>
        public void LoadOrders()
        {
            _orders.Clear();

            foreach (Model.Customer customer in Customers)
            {
                foreach (Model.Orders.Order order in customer.Orders)
                {
                    Model.Orders.OrderEntry entry = new Model.Orders.OrderEntry();
                    entry.Customer = customer;
                    entry.Order = order;

                    _orders.Add(entry);
                }
            }
            
            OrdersDataGridView.Update();

            addressControl.Address = new Model.Address();
            SelectedOrderIdTextBox.Text = "";
            SelectedOrderCreatedAtTtextBox.Text = "";
            SelectedOrderStatusComboBox.SelectedIndex = -1;
            SelectedOrderAmountInfoLabel.Text = "0";
            TotalLabel.Text = "";
            DiscountLabel.Text = "";
            SelectedOrderItemsListView.Items.Clear();
            SelectedOrderPriorityPanel.Visible = false;
        }

        /// <summary>
        /// Обновляет данные в правом окне
        /// </summary>
        /// <param name="entry">Источник данных</param>
        public void UpdateOrder(Model.Orders.OrderEntry entry)
        {
            addressControl.Address = entry.Order.Address;
            SelectedOrderIdTextBox.Text = entry.Id.ToString();
            SelectedOrderCreatedAtTtextBox.Text = entry.CreatingDate.ToString();
            SelectedOrderStatusComboBox.SelectedIndex = (int)entry.Status;
            SelectedOrderAmountInfoLabel.Text = entry.Amount.ToString() + "$";
            TotalLabel.Text = entry.Total.ToString() + "$";
            DiscountLabel.Text = entry.Discount.ToString() + "$";
            SelectedOrderItemsListView.Items.Clear();
            foreach (Model.Item item in entry.Order.Cart.Items)
            {
                SelectedOrderItemsListView.Items.Add(item.ToString());
            }
            if (entry.Order is Model.Orders.PriorityOrder)
            {
                SelectedOrderPriorityPanel.Visible = true;
                SelectedOrderDeliveryTimeComboBox.SelectedIndex = ((Model.Orders.PriorityOrder)entry.Order).DeliveryTime;
            }
            else
            {
                SelectedOrderPriorityPanel.Visible = false;
            }
        }
        #endregion

        #region OrdersTabs Listeners
        public void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) return;

            UpdateOrder(_order);
        }

        public void SelectedOrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrderStatusComboBox.SelectedIndex == (int)_order.Status || SelectedOrderStatusComboBox.SelectedIndex == -1) return;

            _order.Order.Status = (Model.Enumerators.OrderStatus)SelectedOrderStatusComboBox.SelectedIndex;
            OrdersDataGridView.Refresh();
        }

        public void SelectedOrderDeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrderDeliveryTimeComboBox.SelectedIndex == ((Model.Orders.PriorityOrder)_order.Order).DeliveryTime || SelectedOrderDeliveryTimeComboBox.SelectedIndex == -1) return;

            ((Model.Orders.PriorityOrder)_order.Order).DeliveryTime = SelectedOrderDeliveryTimeComboBox.SelectedIndex;
        }
        #endregion
    }
}
