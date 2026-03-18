using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, содержащий основную логику ViewModel и данные для привязки
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Ссылка на экзмепляр <see cref="Contact"/>
        /// </summary>
        private Contact _contact = new Contact();

        /// <summary>
        /// Контакт
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
        }

        /// <summary>
        /// Имя контакта
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                _contact.Name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Телефонный номер контакта
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        /// <summary>
        /// Электронный адрес контакта
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                _contact.Email = value;
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Экземпляр <see cref="LoadCommand"/>, используемый для работы кнопки "Load"
        /// </summary>
        public LoadCommand LoadCommand { get; set; }
        /// <summary>
        /// Экземпляр <see cref="SaveCommand"/>, используемый для работы кнопки "Save"
        /// </summary>
        public SaveCommand SaveCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Тригер, вызываемый при изменении данных о контакте
        /// </summary>
        /// <param name="prop">Имя свойства</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public MainVM()
        {
            LoadCommand = new LoadCommand(this);
            SaveCommand = new SaveCommand();
        }
    }
}
