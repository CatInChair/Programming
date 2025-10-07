using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Enumerators
{
    /// <summary>
    /// Перечисление категорий товаров <see cref="Model.Item">Item</see>
    /// </summary>
    public enum Category
    {
        /// <summary>
        /// Продукты питания
        /// </summary>
        Food,
        /// <summary>
        /// Одежда
        /// </summary>
        Cloth,
        /// <summary>
        /// Электроника
        /// </summary>
        Electronic,
        /// <summary>
        /// Аксессуары
        /// </summary>
        Accessories,
        /// <summary>
        /// Спортивные принадлежности
        /// </summary>
        SportsEquipment,
        /// <summary>
        /// Строй. материалы
        /// </summary>
        BuildingMaterial,
        /// <summary>
        /// Садовый инвентарь
        /// </summary>
        GardenEquipment,
        /// <summary>
        /// Прочие товары
        /// </summary>
        Custom
    }
}
