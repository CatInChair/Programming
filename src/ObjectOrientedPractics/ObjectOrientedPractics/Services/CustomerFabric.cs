using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор клиентов
    /// </summary>
    public static class CustomerFabric
    {
        static private List<Model.Customer> _pregen = new List<Model.Customer>
        {
            new Model.Customer("Kale", new Model.Address(111111, "asd", "asd", "asd", "asd", "asd")),
            new Model.Customer("Jane", new Model.Address()),
            new Model.Customer("Jacob", new Model.Address())
        };

        /// <summary>
        /// Возвращает набор новых объектов
        /// </summary>
        /// <returns><see cref="List">List</see> экземпляров <see cref="Model.Customer">Customer</see></returns>
        public static List<Model.Customer> Generate(/*int amount*/)
        {
            /*List<Model.Item> items = new List<Model.Item>();

            for (int i = 0; i < amount; i++)
            {
                items.Add(new Model.Item(...));
            }

            return items;*/
            return _pregen;
        }
    }
}
