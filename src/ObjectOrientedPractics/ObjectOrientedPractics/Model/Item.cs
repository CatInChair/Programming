using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        // Уникальный идентификатор экземпляра
        private readonly int _id;

        // Название товара (до 200 символов)
        private string _name;

        // Описани карточки товара (до 1000 символов)
        private string _info;

        // Стоимость позиции (до 100000)
        private double _cost;

        public int Id 
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validators.AssertStringOnLength(value, 200, "Item.Name");
                _name = value;
            }
        }

        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                Validators.AssertStringOnLength(value, 1000, "Item.Info");
                _info = value;
            }
        }

        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Item.Cost must be more or equal than 0 and less or equal than 100000");
                }

                _cost = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Cost}$";
        }

        public Item(string name, string info, double cost)
        {
            _id = IdGenerator.getNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
