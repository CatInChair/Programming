using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private int _phoneNumber;
        private string _surname;
        private string _name;

        private bool AssertStringContainsOnlyLetters(string value, string property)
        {
            if (!(Regex.Match(value, @"[a-zA-Z]+").Length == value.Length))
            {
                throw new ArgumentException($"{property} field can contains only English lower and upper case letters.");
            }

            return true;
        }

        public int GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public string GetSurname() 
        { 
            return _surname;
        }
        public string GetName() 
        {
            return _name;
        }

        public void SetPhoneNumber(int value)
        {
            _phoneNumber = value;
        }
        public void SetSurname(string value) 
        {
            AssertStringContainsOnlyLetters(value, "Contact.Surname");

            _surname = value;
        }
        public void SetName(string value) 
        {
            AssertStringContainsOnlyLetters(value, "Contact.Name");

            _name = value; 
        }

        public Contact(int phone, string forename, string surname)
        {
            this.SetName(forename);
            this.SetSurname(surname);
            this.SetPhoneNumber(phone);
        }

        public Contact() { }
    }
}
