using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представление заказа
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        private protected int _id;
        private protected DateTime _creatingDate;
        private protected Model.Address _address;
        private protected Model.Cart _cart;
        private protected Model.Enumerators.OrderStatus _status;
        
        /// <summary>
        /// Индентификатор
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Стоимость корзины
        /// </summary>
        public double Amount
        {
            get
            {
                return _cart.Amount;
            }
        }

        /// <summary>
        /// Дата оформления
        /// </summary>
        public DateTime CreatingDate
        {
            get
            {
                return _creatingDate;
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
        }

        /// <summary>
        /// Корзина товаров
        /// </summary>
        public Model.Cart Cart
        {
            get
            {
                return _cart;
            }
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public Model.Enumerators.OrderStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        /// <summary>
        /// Коструктор заказа
        /// </summary>
        /// <param name="address">Адрес доставки</param>
        /// <param name="cart">Корзина товаров</param>
        public Order(Model.Address address, Model.Cart cart) 
        {
            _id = Services.IdGenerator.getNextId();
            _creatingDate = DateTime.Now;
            _address = address;
            _cart = cart;
            _status = Model.Enumerators.OrderStatus.New;
        }
    }
}
