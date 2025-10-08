using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, хранящий данные о товарах и клиентах
    /// </summary>
    public class Store
    {
        private List<Model.Item> _items = new List<Model.Item>();
        private List<Model.Customer> _customers = new List<Model.Customer>();

        /// <summary>
        /// 
        /// </summary>
        public List<Model.Item> Items
        {
            get 
            { 
                return _items; 
            }
            set
            {
                _items = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public List<Model.Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Store()
        {

        }
    }
}
