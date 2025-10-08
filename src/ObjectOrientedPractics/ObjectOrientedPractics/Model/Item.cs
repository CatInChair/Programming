using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий товар
    /// </summary>
    public class Item
    {
        private readonly int _id;

        private string _name;
        private string _info;
        
        private double _cost;

        /// <summary>
        /// Уникальный идентификатор экземпляра
        /// </summary>
        public int Id 
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Название товара (до 200 символов)
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, "Item.Name");
                _name = value;
            }
        }

        /// <summary>
        /// Описани карточки товара (до 1000 символов)
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                Validator.AssertStringOnLength(value, 1000, "Item.Info");
                _info = value;
            }
        }

        /// <summary>
        /// Стоимость позиции (до 100000)
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                Validator.AssertValueOnRange(value, 0.0, 100000.0, "Item.Cost");

                _cost = value;
            }
        }

        /// <summary>
        /// Категория товара
        /// </summary>
        public Model.Enumerators.Category Category { get; set; }

        /// <summary>
        /// Конвертация в строковое значение
        /// </summary>
        /// <returns>Строковое представление объекта</returns>
        public override string ToString()
        {
            return $"{this.Name} - {this.Cost}$";
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя нового товара</param>
        /// <param name="info">Ифнормация о новом товаре</param>
        /// <param name="cost">Стоимость нового товара</param>
        /// <param name="category">Категория нового товара. Член перечисления <see cref="Model.Enumerators.Category">Category</see></param>
        public Item(string name, string info, double cost, Model.Enumerators.Category category)
        {
            _id = IdGenerator.getNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
    }
}
