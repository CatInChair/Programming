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
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Экземпляр адреса
        /// </summary>
        private Model.Address _address = new Model.Address();

        /// <summary>
        /// Открытые свойства приватного поля <see cref="_address">_address</see>
        /// </summary>
        public Model.Address Address
        {
            get 
            { 
                return _address; 
            }
            set
            {
                _ResetAddress();
                _LoadAddressValues(value);

                _address = value;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            InitializeListeners();
        }

        #region Functions
        /// <summary>
        /// Сбрасывает текущий адрес
        /// </summary>
        private void _ResetAddress()
        {
            _address = new Model.Address();
            _LoadAddressValues(_address);
        }

        /// <summary>
        /// Загружает данные о переданном адресе
        /// </summary>
        /// <param name="address">Источник данных</param>
        private void _LoadAddressValues(Model.Address address)
        {
            AddressIndexTextBox.Text = Convert.ToString(address.Index);
            AddressCountryTextBox.Text = address.Country;
            AddressCityTextBox.Text = address.City;
            AddressStreetTextBox.Text = address.Street;
            AddressBuildingTextBox.Text = address.Building;
            AddressApartmentTextBox.Text = address.Apartment;
        }
        #endregion

        #region Listeners
        public void AddressIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddressIndexTextBox.Text == "")
            {
                return;
            }

            int content;

            if (!Int32.TryParse(AddressIndexTextBox.Text, out content))
            {
                AddressIndexTextBox.BackColor = Color.Red;
                MessageBox.Show("Address.Index must be a real number!");
                return;
            }

            AddressIndexTextBox.BackColor = SystemColors.Window;

            if (content == _address.Index)
            {
                return;
            }

            try
            {
                _address.Index = content;
            }
            catch
            {
                AddressIndexTextBox.BackColor = Color.Red;
                MessageBox.Show("Address length must be more than 99999 and less than 1000000.");
                return;
            }
        }

        public void AddressCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            string content = AddressCountryTextBox.Text;
            AddressCountryTextBox.BackColor = SystemColors.Window;

            if (content == _address.Country)
            {
                return;
            }

            try
            {
                _address.Country = content;
            }
            catch
            {
                AddressCountryTextBox.BackColor = Color.Red;
                MessageBox.Show("Address.Country length must be less or equal than 50.");
            }
        }

        public void AddressCityTextBox_TextChanged(object sender, EventArgs e)
        {
            string content = AddressCityTextBox.Text;
            AddressCityTextBox.BackColor = SystemColors.Window;

            if (content == _address.City)
            {
                return;
            }

            try
            {
                _address.City = content;
            }
            catch
            {
                AddressCityTextBox.BackColor = Color.Red;
                MessageBox.Show("Address.City length must be less or equal than 50.");
            }
        }

        public void AddressStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            string content = AddressStreetTextBox.Text;
            AddressStreetTextBox.BackColor = SystemColors.Window;

            if (content == _address.Street)
            {
                return;
            }

            try
            {
                _address.Street = content;
            }
            catch
            {
                AddressStreetTextBox.BackColor = Color.Red;
                MessageBox.Show("Address.Street length must be less or equal than 100.");
            }
        }

        public void AddressBuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            string content = AddressBuildingTextBox.Text;
            AddressBuildingTextBox.BackColor = SystemColors.Window;

            if (content == _address.Building)
            {
                return;
            }

            try
            {
                _address.Building = content;
            }
            catch
            {
                AddressBuildingTextBox.BackColor = Color.Red;
                MessageBox.Show("Address.Building length must be less or equal than 10.");
            }
        }

        public void AddressApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            string content = AddressApartmentTextBox.Text;
            AddressApartmentTextBox.BackColor = SystemColors.Window;

            if (content == _address.Apartment)
            {
                return;
            }

            try
            {
                _address.Apartment = content;
            }
            catch
            {
                AddressApartmentTextBox.BackColor = Color.Red;
                MessageBox.Show("Address.Apartment length must be less or equal than 10.");
            }
        }
        #endregion
    }
}
