using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие ввода в TextBox с номером телефона
        /// </summary>
        /// <param name="sender">Источник</param>
        /// <param name="e">Параметры события</param>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[0-9]|\+|\(|\)"))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Событие вставки из буфера обмена в TextBox с номеров телефона
        /// </summary>
        /// <param name="sender">Источник</param>
        /// <param name="e">Параметры события</param>
        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            e.Handled = true;
        }
    }
}
