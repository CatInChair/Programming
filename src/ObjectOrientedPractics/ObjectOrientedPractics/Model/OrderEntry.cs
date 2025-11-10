using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Абстракция для представления данных внутри DataGridView
    /// </summary>
    public class OrderEntry
    {
        /// <summary>
        /// Экземпляр заказа
        /// </summary>
        private Model.Order _order;
        /// <summary>
        /// Экземпляр пользователя
        /// </summary>
        private Model.Customer _customer;

        /// <summary>
        /// Экземпляр заказа
        /// </summary>
        public Model.Order Order
        {
            get 
            { 
                return _order; 
            }
            set
            {
                _order = value;
            }
        }

        /// <summary>
        /// Экземпляр пользователя
        /// </summary>
        public Model.Customer Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
            }
        }

        /// <summary>
        /// Id заказа
        /// </summary>
        public int Id
        {
            get
            {
                return _order.Id;
            }
        }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        public DateTime CreatingDate
        {
            get
            {
                return _order.CreatingDate;
            }
        }

        /// <summary>
        /// Полное имя заказчика
        /// </summary>
        public string Fullname
        {
            get
            {
                return _customer.Fullname;
            }
        }

        /// <summary>
        /// Адрес доставки заказа
        /// </summary>
        public string Address
        {
            get
            {
                return _order.Address.FullAddress;
            }
        }

        /// <summary>
        /// Стоимость заказа
        /// </summary>
        public double Amount
        {
            get
            {
                return _order.Amount;
            }
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public Model.Enumerators.OrderStatus Status
        {
            get
            {
                return _order.Status;
            }
        }
    }
}
