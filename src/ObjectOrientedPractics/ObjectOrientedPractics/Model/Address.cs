using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Аргументы события изменения объекта адреса
    /// </summary>
    public class AddressEventArgs : EventArgs
    {
        public Address OldState { get; set; }
        public Address NewState { get; set; }
    }

    /// <summary>
    /// Представление адреса посетителя
    /// </summary>
    public class Address : ICloneable
    {
        /// <summary>
        /// Событие изменения состояния адреса
        /// </summary>
        public event EventHandler<AddressEventArgs> AddressChanged;

        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// Почтовый индекс
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                Validator.AssertValueOnRange(value, 999999, 100000, "Address.Index");
                AddressEventArgs e = new AddressEventArgs();
                e.OldState = (Address)this.Clone();
                _index = value;
                e.NewState = this;
                AddressChanged?.Invoke(this, e);
            }
        }
        /// <summary>
        /// Страна/регион
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                Validator.AssertStringOnLength(value, 50, "Address.Country");

                _country = value;
            }
        }
        /// <summary>
        /// Город/населенный пункт
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                Validator.AssertStringOnLength(value, 50, "Address.City");

                _city = value;
            }
        }
        /// <summary>
        /// Улица
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                Validator.AssertStringOnLength(value, 100, "Address.Street");

                _street = value;
            }
        }
        /// <summary>
        /// Номер дома
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                Validator.AssertStringOnLength(value, 10, "Address.Building");

                _building = value;
            }
        }
        /// <summary>
        /// Номер квартиры/помещения    
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                Validator.AssertStringOnLength(value, 10, "Address.Apartment");

                _apartment = value;
            }
        }

        /// <summary>
        /// Строковое представление объекта
        /// </summary>
        public string FullAddress 
        {
            get
            {
                return this.Index + ": " + this.Country + ", " + this.City + ", " + this.Street + ", " + this.Building + " " + this.Apartment;
            }
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
        {
            if (other is null) return false;

            if (!(other is Address)) return false;

            return ((Address)other).FullAddress == this.FullAddress;
        }

        /// <summary>
        /// Инициализатор пустого экземпляра адреса
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Конструктор адреса
        /// </summary>
        /// <param name="index">Почтовый индекс</param>
        /// <param name="country">Страна/Регион</param>
        /// <param name="city">Город/Населенный пункт</param>
        /// <param name="street">Улица</param>
        /// <param name="building">Номер дома</param>
        /// <param name="apartment">Номер квартиры/Помещения</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index =  index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
