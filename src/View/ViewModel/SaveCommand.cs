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
    /// Класс, содержащий логику команды для кнопки "Save"
    /// </summary>
    public class SaveCommand : ICommand
    {
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
            ContactSerializer.SaveContact(parameter);
        }
    }
}
