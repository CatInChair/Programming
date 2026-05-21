using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class Contact : ObservableObject
    {
        /// <summary>
        /// Имя контакта
        /// </summary>
        [ObservableProperty]
        private string _name = "";

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber = "";

        /// <summary>
        /// Адрес электронной почты контакта
        /// </summary>
        [ObservableProperty]
        private string _email = "";

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
