using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace View.Model
{
    /// <summary>
    /// Представление контакта
    /// </summary>
    public class Contact
    {
        private string _name = "";

        private string _phoneNumber = "";

        private string _email = "";

        /// <summary>
        /// Имя контакта
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set 
            { 
                _name = value;
            }
        }

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        public string PhoneNumber
        {
            get 
            { 
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Адрес электронной почты контакта
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Конструктор нового экземпляра <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="email">Адрес электронной почты</param>
        public Contact(string name, string phoneNumber, string email) 
        { 
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Конструктор по умолчанию для <see cref="Contact"/>
        /// </summary>
        public Contact()
        { 
        }
    }
}
