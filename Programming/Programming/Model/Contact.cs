using System;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий собой контакт в телефонной книге.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Contact.PhoneNumber");

                _phoneNumber = value;
            }
        }
        private int _phoneNumber;
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, "Contact.Surname");

                _surname = value;
            }
        }
        private string _surname;
        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, "Contact.Name");

                _name = value;
            }
        }
        private string _name;

        /// <summary>
        /// Проверяет, содержит ли строка лишь символы английского алфавита.
        /// </summary>
        /// <param name="value">Строка, требующая проверки.</param>
        /// <param name="property">Свойство, на которое будет ссылаться ArgumentException при наличии в переданной строке символов, не принадлежащих английскому алфавиту.</param>
        /// <returns>Возвращает true, если строка соддержит лишь символы английского алфавита, иначе метод вызовет <see cref="ArgumentException"/> исключение.</returns>
        /// <exception cref="ArgumentException"></exception>
        private bool AssertStringContainsOnlyLetters(string value, string property)
        {
            if (!(Regex.Match(value, @"[a-zA-Z]+").Length == value.Length))
            {
                throw new ArgumentException($"{property} field can contains only English lower and upper case letters.");
            }

            return true;
        }

        /// <summary>
        /// Конструктор класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="phone">Телефонный номер контакта.</param>
        /// <param name="name">Имя контакта.</param>
        /// <param name="surname">Фамилия контакта.</param>
        public Contact(int phone, string name, string surname)
        {
            Name = name;
            Name = surname;
            PhoneNumber = phone;
        }

        /// <summary>
        /// Конструктор пустого экземпляра класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }
    }
}
