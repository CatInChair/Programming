
using View.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using View.Model.Services;
using System.Windows.Controls;
using System.ComponentModel;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, содержащий основную логику ViewModel и данные для привязки
    /// </summary>
    public partial class MainVM : ObservableObject
    {

        /// <summary>
        /// Ссылка на выбранный экзмепляр <see cref="Contact"/>
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsRemoveButtonEnabled))]
        [NotifyPropertyChangedFor(nameof(IsEditButtonEnabled))]
        private Contact? _contact = null;

        /// <summary>
        /// Привязанная переменная имени контакта
        /// </summary>
        [ObservableProperty]
        private string _bindedName;

        /// <summary>
        /// Привязанная переменная телефона контакта
        /// </summary>
        [ObservableProperty]
        private string _bindedPhoneNumber;

        /// <summary>
        /// Привязанная переменная почты контакта
        /// </summary>
        [ObservableProperty]
        private string _bindedEmail;

        /// <summary>
        /// Список ссылок на экземпляры существующих контактов
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Contact> _contacts = null;

        /// <summary>
        /// Флаг состояния перехода в режим создания контакта
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsRemoveButtonEnabled))]
        [NotifyPropertyChangedFor(nameof(IsEditButtonEnabled))]
        [NotifyPropertyChangedFor(nameof(IsApplyButtonEnabled))]
        [NotifyPropertyChangedFor(nameof(TextBoxesReadOnlyState))]
        private Boolean _isAddModeEnabled = false;

        /// <summary>
        /// Флаг состояния перехода в режим редактирования контакта
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsApplyButtonEnabled))]
        [NotifyPropertyChangedFor(nameof(TextBoxesReadOnlyState))]
        private Boolean _isEditModeEnabled = false;

        /// <summary>
        /// Флаг, определяющий являются ли поля ввода правого окна доступными
        /// </summary>
        public Boolean TextBoxesReadOnlyState
        {
            get
            {
                return !IsEditModeEnabled && !IsAddModeEnabled;
            }
        }

        /// <summary>
        /// Флаг, определяющий доступность кнопки подтверждения
        /// </summary>
        public Boolean IsApplyButtonEnabled
        {
            get
            {
                return IsEditModeEnabled || IsAddModeEnabled;
            }
        }

        /// <summary>
        /// Флаг, определяющий доступность кнопки редактирования
        /// </summary>
        public Boolean IsEditButtonEnabled
        {
            get
            {
                return !(Contact is null) && !IsAddModeEnabled;
            }
        }

        /// <summary>
        /// Флаг, определяющий доступность кнопки удаления
        /// </summary>
        public Boolean IsRemoveButtonEnabled
        {
            get
            {
                return !(Contact is null) && !IsAddModeEnabled;
            }
        }

        /// <summary>
        /// Команда для перехода в режим добавления контакта
        /// </summary>
        [RelayCommand]
        public void Add()
        {
            Contact = new Contact();
            BindedName = Contact.Name;
            BindedEmail = Contact.Email;
            BindedPhoneNumber = Contact.PhoneNumber;
            IsAddModeEnabled = true;
            IsEditModeEnabled = false;
        }

        /// <summary>
        /// Команда для перехода в режим редактирования контакта
        /// </summary>
        [RelayCommand]
        public void Edit()
        {
            IsAddModeEnabled = false;
            IsEditModeEnabled = true;
        }

        /// <summary>
        /// Вспомогательный метод для очистки значений свойств, привязанных к текстовым полям
        /// </summary>
        private void ClearBindedValues()
        {
            BindedName = "";
            BindedEmail = "";
            BindedPhoneNumber = "";
        }

        /// <summary>
        /// Команда для удаления контакта
        /// </summary>
        [RelayCommand]
        public void Remove()
        {
            Contacts.Remove(Contact);
            ClearBindedValues();
            Contact = null;

            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Команда для кнопки подтверждения
        /// </summary>
        [RelayCommand]
        public void Apply()
        {
            Contact.Name = BindedName;
            Contact.Email = BindedEmail;
            Contact.PhoneNumber = BindedPhoneNumber;

            if (IsAddModeEnabled && !(Contact is null)) 
            {
                Contacts.Add(Contact);
                IsAddModeEnabled = false;
            }
            else
            {
                IsEditModeEnabled = false;
            }

            Contact = null;
            ClearBindedValues();

            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Событие выбора контакта в списке
        /// </summary>
        [RelayCommand]
        public void ListBox_SelectionChanged(SelectionChangedEventArgs args)
        {
            if (args.AddedItems.Count > 0)
            {
                Contact = Contacts[Contacts.IndexOf((Contact)args.AddedItems[0])];
                BindedName = Contact.Name;
                BindedEmail = Contact.Email;
                BindedPhoneNumber = Contact.PhoneNumber;
                IsAddModeEnabled = false;
                IsEditModeEnabled = false;
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.ReadContacts();
        }
    }
}
