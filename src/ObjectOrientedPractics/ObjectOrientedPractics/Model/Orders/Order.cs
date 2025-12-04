using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Представление заказа
    /// </summary>
    public class Order
    {
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
        /// Размер примененной скидки
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Итоговая стоимость
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
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


        /// <inheritdoc/>
        public override bool Equals(object other)
        {
            if (other is null) return false;

            if (!(other is Order)) return false;

            return ((Order)other).Id == Id;
        }

        /// <summary>
        /// Коструктор заказа
        /// </summary>
        /// <param name="address">Адрес доставки</param>
        /// <param name="cart">Корзина товаров</param>
        public Order(Model.Address address, Model.Cart cart, double discount) 
        {
            _id = Services.IdGenerator.getNextId();
            _creatingDate = DateTime.Now;
            _address = address;
            _cart = cart;
            _status = Model.Enumerators.OrderStatus.New;
            DiscountAmount = discount;
        }
    }
}
