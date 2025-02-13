using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming3.Model
{
    public class Contacts
    {
        private int _phoneNumber;
        private string _surname;
        private string _forename;

        public int GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public string GetSurname() 
        { 
            return _surname;
        }
        public string GetForename() 
        {
            return _forename;
        }

        public void SetPhoneNumber(int value)
        {
            _phoneNumber = value;
        }
        public void SetSurname(string value) 
        { 
            _forename = value;
        }
        public void SetForename(string value) 
        { 
            _forename = value; 
        }

        public Contacts(int phone, string forename, string surname)
        {
            this.SetForename(forename);
            this.SetSurname(surname);
            this.SetPhoneNumber(phone);
        }

        public Contacts() { }
    }
}
