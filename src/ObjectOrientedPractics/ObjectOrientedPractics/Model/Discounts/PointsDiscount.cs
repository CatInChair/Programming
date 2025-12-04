using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Представление балльной системы
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        private int _points = 0;

        /// <summary>
        /// Количество баллов
        /// </summary>
        public int Points 
        { 
            get 
            {
                return _points;
            } 
        }

        /// <summary>
        /// Информация
        /// </summary>
        public string Info
        {
            get
            {
                return "Накопительная - " + _points + " баллов";
            }
        }

        /// <summary>
        /// Вычисление размера скидки
        /// </summary>
        /// <param name="items">Список товраов</param>
        /// <returns>Размер возможной скидки</returns>
        public double Calculate(List<Item> items)
        {
            int discount = _points;
            double cost = 0;

            foreach (Item item in items)
            {
                cost += item.Cost;
            }

            if (cost*0.3 < discount) discount = (int)Math.Floor(cost*0.3);

            return discount;
        }

        /// <summary>
        /// Применяет скидку к товарам
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>азмер скидки</returns>
        public double Apply(List<Item> items)
        {
            int discount = (int)Calculate(items);
            _points -= discount;
            Update(items);

            return discount;
        }

        /// <summary>
        /// Начисляет баллы за покупку
        /// </summary>
        /// <param name="items">Список товаров</param>
        public void Update(List<Item> items)
        {
            double cost = 0;

            foreach (Item item in items)
            {
                cost += item.Cost;
            }

            _points += (int)Math.Floor(cost * 0.1);
        }

        /// <inheritdoc/>
        int CompareTo(PointsDiscount other)
        {
            if (other == null) return 1;

            if (other.Points == Points) return 0;

            return Points > other.Points ? 1 : 0;
        }
    }
}
