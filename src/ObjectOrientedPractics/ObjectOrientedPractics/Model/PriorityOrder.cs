using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представление приоритетного заказа. Расширение для <see cref="Order">Order</see>
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Закрытое поле времени доставки
        /// </summary>
        private int _deliveryTime;

        /// <summary>
        /// Открытое поле времени доставки.
        /// Represent values:
        /// 0 - "9:00 – 11:00",
        /// 1 - "11:00 – 13:00",
        /// 2 - "13:00 – 15:00",
        /// 3 - "15:00 – 17:00",
        /// 4 - "17:00 – 19:00",
        /// 5 - "19:00 – 21:00"
        /// </summary>
        public int DeliveryTime
        {
            get
            {
                return _deliveryTime;
            }
            set
            {
                Validator.AssertValueOnRange(value, 5, 0, "PriorityOrder.DeliveryTime");
                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="address">Адрес доставки</param>
        /// <param name="cart">Корзина пользователя</param>
        public PriorityOrder(Address address, Cart cart) : base(address, cart)
        { }
    }
}
