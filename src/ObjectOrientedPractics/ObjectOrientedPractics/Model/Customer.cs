using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представление клиента
    /// </summary>
    public class Customer
    {
        private readonly int _id;
        private string _fullname;
        private Model.Address _address;
        private Model.Cart _cart;
        private List<Orders.Order> _orders;

        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
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
        /// Корзина покупателя
        /// </summary>
        public Model.Cart Cart
        {
            get
            {
                return _cart;
            }
        }

        /// <summary>
        /// Список заказов пользователя
        /// </summary>
        public List<Orders.Order> Orders
        {
            get
            {
                return _orders;
            }
        }

        /// <summary>
        /// Список скидок
        /// </summary>
        public List<IDiscount> Discounts { get; } = new List<IDiscount>() { new Discounts.PointsDiscount() };

        /// <summary>
        /// Указывает на наличие приоритетного статуса
        /// </summary>
        public bool IsPriority { get; set; } = false;

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
            _cart = new Model.Cart();
            _orders = new List<Orders.Order>();
        }
    }
}
