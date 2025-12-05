using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class NameEventArgs : EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }
    }

    public class CostEventArgs : EventArgs
    {
        public double OldCost { get; set; }
        public double NewCost { get; set; }
    }

    public class InfoEventArgs : EventArgs
    {
        public string OldInfo { get; set; }
        public string NewInfo { get; set; }
    }

    /// <summary>
    /// Представление товара
    /// </summary>
    public class Item : ICloneable
    {
        /// <summary>
        /// Событие изменения названия товара
        /// </summary>
        public event EventHandler<NameEventArgs> NameChanged;
        /// <summary>
        /// Событие изменения стоимости товара
        /// </summary>
        public event EventHandler<CostEventArgs> CostChanged;
        /// <summary>
        /// Событие изменения информации о товаре
        /// </summary>
        public event EventHandler<InfoEventArgs> InfoChanged;

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
                NameEventArgs e = new NameEventArgs();
                e.OldName = _name;
                e.NewName = value;
                NameChanged?.Invoke(this, e);
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
                InfoEventArgs e = new InfoEventArgs();
                e.OldInfo = _info;
                e.NewInfo = value;
                InfoChanged?.Invoke(this, e);
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
                Validator.AssertValueOnRange(value, 100000.0, 0.0, "Item.Cost");
                CostEventArgs e = new CostEventArgs();
                e.OldCost = _cost;
                e.NewCost = value;
                CostChanged?.Invoke(this, e);
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
            return $"{Id}: {this.Name} - {this.Cost}$";
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost, this.Category);
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
        {
            if (other is null) return false;

            if (!(other is Item)) return false;

            return ((Item)other).Id == this.Id;
        }

        /// <inheritdoc/>
        int CompareTo(Item other)
        {
            if (other == null) return 1;
            
            if (other.Cost == Cost) return 0;

            return Cost > other.Cost ? 1 : -1;
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
