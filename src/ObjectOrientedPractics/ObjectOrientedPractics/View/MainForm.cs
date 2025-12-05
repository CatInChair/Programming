using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Представление магазина
        /// </summary>
        private Model.Store _store = new Model.Store();

        public MainForm()
        {
            InitializeComponent();
            InitializeListeners();

            LinkStore();
            itemsTabs1.ItemOrderByComboBox.SelectedIndex = 0;
            _store.Customers.Add(new Model.Customer("Kale", new Model.Address(111111, "asd", "asd", "asd", "asd", "asd")));
            ReloadTabs();
        }

        public void MainFormTabControl_SelectedIndexChanged(object args, EventArgs e)
        {
            if (MainFormTabControl.SelectedIndex == 2)
            {
                cartsTabs1.LoadPage();
                return;
            }

            if (MainFormTabControl.SelectedIndex == 3)
            {
                ordersTabs1.LoadOrders();
                return;
            }
        }
    }
}
