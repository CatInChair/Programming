using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представление процентной скмдки
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        private int _percent = 1;

        /// <summary>
        /// Категория скидки
        /// </summary>
        public Enumerators.Category Category { get; }
        
        /// <summary>
        /// Размер скидки
        /// </summary>
        public int Percent
        {
            get
            {
                return _percent;
            }
        }

        /// <summary>
        /// Информация
        /// </summary>
        public string Info
        {
            get
            {
                return "Процентная \"" + Category + "\" - " + _percent + "%";
            }
        }

        /// <summary>
        /// Вычисление размера скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Размер скидки</returns>
        public double Calculate(List<Item> items)
        {
            double cost = 0;

            foreach (Item item in items)
            {
                cost += item.Cost;
            }

            return cost * (100 - _percent)/100;
        }

        /// <summary>
        /// Применяет скидку и начисляет баллы
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Размер скидки</returns>
        public double Apply(List<Item> items)
        {
            double dicsount = Calculate(items);
            Update(items);
            return dicsount;
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

            if (_percent < 10 && _percent + (int)cost / 1000 <= 10) _percent += (int)cost / 1000;
        }
    }
}
