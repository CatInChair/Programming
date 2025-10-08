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
        private Model.Store _store = new Model.Store();

        public MainForm()
        {
            InitializeComponent();

            LinkStore();

            _store.Items.Add(new Model.Item("asd", "asd", 123, Model.Enumerators.Category.Custom));
            _store.Customers.Add(new Model.Customer("afd", new Model.Address()));

            ReloadTabs();
        }
    }
}
