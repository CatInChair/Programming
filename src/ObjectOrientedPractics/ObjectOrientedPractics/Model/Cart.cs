using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представление корзины товаров
    /// </summary>
    public class Cart
    {
        private List<Model.Item> _items = new List<Model.Item>();

        /// <summary>
        /// Список товаров в корзине
        /// </summary>
        public List<Model.Item> Items
        {
            get 
            {
                return _items; 
            }
        }

        /// <summary>
        /// Общая стоимость товаров
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0.0;

                Items.ForEach(item =>
                {
                    amount += item.Cost;
                });

                return amount;
            }
        }


    }
}
