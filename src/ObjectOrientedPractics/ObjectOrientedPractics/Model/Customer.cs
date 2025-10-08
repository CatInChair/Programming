using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private readonly int _id;
        private string _fullname;
        private Model.Address _address;

        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public int Id
        {
            get;
        }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, "Customer.Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        public Model.Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Приводит объект к строковому представлению
        /// </summary>
        /// <returns>Строковое представление объекта</returns>
        public override string ToString()
        {
            return $"{this.Fullname}, {this.Id}";
        }

        /// <summary>
        /// Конструктор класса <see cref="Model.Customer">Customer</see>
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="address"></param>
        public Customer(string fullname, Model.Address address)
        {
            _id = IdGenerator.getNextId();
            Fullname = fullname;
            Address = address;
        }
    }
}
