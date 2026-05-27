using CommunityToolkit.Mvvm.ComponentModel;
using FluentValidation;
using System.ComponentModel;

namespace View.Model
{
    /// <summary>
    /// Представление контакта
    /// </summary>
    public partial class Contact : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Валидатор свойств контакта
        /// </summary>
        private ContactValidator _validator = new();

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
        /// Сообщение об ошибке конкретного свойства
        /// </summary>
        /// <param name="columnName">Имя свойства</param>
        /// <returns>Ошибка валидации для конкретного свойства</returns>
        public string this[string columnName]
        {
            get
            {
                var firstOrDefault = _validator.Validate(this).Errors.FirstOrDefault(lol => lol.PropertyName == columnName);
                return firstOrDefault?.ErrorMessage ?? "";
            }
        }

        /// <summary>
        /// Общая ошибка валидации
        /// </summary>
        public string Error
        {
            get
            {
                if (_validator != null)
                {
                    var results = _validator.Validate(this);
                    if (results != null && results.Errors.Any())
                    {
                        var errors = string.Join(Environment.NewLine, results.Errors.Select(x => x.ErrorMessage).ToArray());
                        return errors;
                    }
                }
                return string.Empty;
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

    /// <summary>
    /// Валидатор полей контакта
    /// </summary>
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100).WithMessage("Name length is must be less than 100 symbols.");
            RuleFor(x => x.PhoneNumber).NotEmpty().MaximumLength(100).Matches(@"^([0-9]|\+|\(|\))+$").WithMessage("PhoneNumber length is must be less than 100 symbols and include only numbers and \"+()\" symbols. Example: +7(997)9979797.");
            RuleFor(x => x.Email).NotEmpty().MaximumLength(100).Matches("@").WithMessage("Email length is must be less than 100 symbols and include \"@\" symbol.");
        }
    }
}
