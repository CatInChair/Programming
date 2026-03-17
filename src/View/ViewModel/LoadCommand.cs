using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, содержащий логику команды для кнопки "Load"
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Ссылка на экземпляр <see cref="MainVM">
        /// </summary>
        public MainVM VM;

        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            {
            }

            remove
            {
            }
        }
        
        bool ICommand.CanExecute(object? parameter)
        {
            return true;
        }

        void ICommand.Execute(object? parameter)
        {
            Contact data = ContactSerializer.ReadContact();

            VM.Name = data.Name;
            VM.PhoneNumber = data.PhoneNumber;
            VM.Email = data.Email;
        }

        public LoadCommand(MainVM vm)
        {
            VM = vm;
        }
    }
}