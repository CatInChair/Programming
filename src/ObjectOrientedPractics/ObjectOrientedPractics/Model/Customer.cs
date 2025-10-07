using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        // Уникальный идентификатор товара -> Item.Id
        private readonly int _id;
        // Полное имя клиента
        private string _fullname;
        // Адрес доставки
        private string _address;

        public int Id
        {
            get;
        }

        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                Validators.AssertStringOnLength(value, 200, "Customer.Fullname");
                _fullname = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validators.AssertStringOnLength(value, 500, "Customer.Address");
                _address = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Fullname}, {this.Id}";
        }

        public Customer(string fullname, string address)
        {
            _id = IdGenerator.getNextId();
            Fullname = fullname;
            Address = address;
        }
    }
}
