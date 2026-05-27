using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, содержащий основную логику ViewModel и данные для привязки
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Ссылка на выбранный экзмепляр <see cref="Model.Contact"/>
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsRemoveButtonEnabled))]
        [NotifyPropertyChangedFor(nameof(IsEditButtonEnabled))]
        private Contact? _contact = null;

        /// <summary>
        /// Ссылка на привязанный к элементам управления экземпляр <see cref="Model.Contact"/>
        /// </summary>
        [ObservableProperty]
        public Contact? _currentContact = null;

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
        [NotifyPropertyChangedFor(nameof(IsContactControlEnabled))]
        private Boolean _isAddModeEnabled = false;

        /// <summary>
        /// Флаг состояния перехода в режим редактирования контакта
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsApplyButtonEnabled))]
        [NotifyPropertyChangedFor(nameof(IsContactControlEnabled))]
        private Boolean _isEditModeEnabled = false;

        /// <summary>
        /// Флаг, определяющий является ли правый пользовательный элемент управления доступным
        /// </summary>
        public Boolean IsContactControlEnabled
        {
            get
            {
                return IsEditModeEnabled || IsAddModeEnabled;
            }
        }

        /// <summary>
        /// Флаг, определяющий доступность кнопки подтверждения
        /// </summary>
        public Boolean IsApplyButtonEnabled
        {
            get
            {
                return (IsEditModeEnabled || IsAddModeEnabled) && string.IsNullOrEmpty(CurrentContact.Error);
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
            CurrentContact = new Contact();
            CurrentContact.PropertyChanged += CurrentContact_PropertyChanged;
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
            CurrentContact = null;
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
            CurrentContact = null;

            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Команда для кнопки подтверждения
        /// </summary>
        [RelayCommand]
        public void Apply()
        {
            Contact.Name = CurrentContact.Name;
            Contact.Email = CurrentContact.Email;
            Contact.PhoneNumber = CurrentContact.PhoneNumber;

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
                CurrentContact = new Contact(Contact.Name, Contact.PhoneNumber, Contact.Email);
                CurrentContact.PropertyChanged += CurrentContact_PropertyChanged;
                IsAddModeEnabled = false;
                IsEditModeEnabled = false;
            }
        }

        private void CurrentContact_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(nameof(IsApplyButtonEnabled));
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
