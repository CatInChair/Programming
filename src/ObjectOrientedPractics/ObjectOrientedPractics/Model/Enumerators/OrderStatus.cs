using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Enumerators
{
    /// <summary>
    /// Состояния заказа
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ
        /// </summary>
        New,
        /// <summary>
        /// В обработке
        /// </summary>
        Processing,
        /// <summary>
        /// Формируется
        /// </summary>
        Assembly,
        /// <summary>
        /// Отправлен
        /// </summary>
        Sent,
        /// <summary>
        /// Доставлен
        /// </summary>
        Delivered,
        /// <summary>
        /// Возвращен
        /// </summary>
        Returned,
        /// <summary>
        /// Отозван
        /// </summary>
        Abandoned
    }
}
