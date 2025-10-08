using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор товаров
    /// </summary>
    public static class ItemFabric
    {
        static private List<Model.Item> _pregen = new List<Model.Item> 
        { 
            new Model.Item("Pen", "This is very good pen", 1.498, Model.Enumerators.Category.Electronic),
            new Model.Item("Apple", "Ohh, fruits!", 99.4, Model.Enumerators.Category.GardenEquipment),
            new Model.Item("Shirt", "Light-weight cloth", 1234, Model.Enumerators.Category.Food)
        };

        /// <summary>
        /// Возвращает набор новых объектов
        /// </summary>
        /// <returns><see cref="List">List</see> экземпляров <see cref="Model.Item">Item</see></returns>
        public static List<Model.Item> Generate(/*int amount*/) 
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
