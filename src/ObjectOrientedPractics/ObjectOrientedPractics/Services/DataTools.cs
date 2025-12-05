using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Методы для обработки данных.
    /// </summary>
    public static class DataTools
    {
        public delegate bool SortFunction(Model.Item now, Model.Item next);

        /// <summary>
        /// Фильтрация приведенного списка.
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <param name="filter">Функция фильтрации</param>
        /// <returns>Отфильтрованный список</returns>
        public static List<Model.Item> Filter(List<Model.Item> items, Func<Model.Item, bool> filter)
        {
            List<Model.Item> filtered = new List<Model.Item>();

            foreach (Model.Item item in items)
            {
                if (filter(item)) filtered.Add(item);
            }

            return filtered;
        }

        /// <summary>
        /// Сортировка приведенного списка.
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <param name="sort">Функция сортировки</param>
        /// <returns>Отсортированный список</returns>
        public static List<Model.Item> Sort(List<Model.Item> items, SortFunction sort)
        {
            if (items.Count == 0) return items;

            List<Model.Item> sorted = new List<Model.Item>(items);
            bool hasTransitions = true;
            int sortedLine = sorted.Count();

            while (hasTransitions && sortedLine > 0)
            {
                for (int i = 0; i < sortedLine - 1; i++)
                {
                    if (sort(sorted[i], sorted[i + 1]))
                    {
                        Model.Item temp = sorted[i];
                        sorted[i] = sorted[i+1];
                        sorted[i+1] = temp;
                        hasTransitions = true;
                    }
                }
                sortedLine--;
            }

            return sorted;
        }
    }
}
