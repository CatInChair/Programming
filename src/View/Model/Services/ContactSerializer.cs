using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace View.Model.Services
{
    /// <summary>
    /// Сервисный класс, используемый для сохранения и чтения контактов
    /// </summary>
    class ContactSerializer
    {
        /// <summary>
        /// Путь к папке сохранения контактов
        /// </summary>
        static private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Contacts\\";
        /// <summary>
        /// Имя файла, в которое происходит сохранение
        /// </summary>
        static private string _filename = "contacts.json";

        /// <summary>
        /// Сохраняет данные контакта в файл в формате JSON
        /// </summary>
        /// <param name="contact">Объект контакта</param>
        static public void SaveContacts(ObservableCollection<Contact> contacts)
        {
            DirectoryInfo dir = new DirectoryInfo(_path);
            if (!dir.Exists)
            {
                dir.Create();
            }
            
            File.WriteAllText(_path + _filename, JsonConvert.SerializeObject(contacts));
        }

        /// <summary>
        /// Читает данные контакта из файла
        /// </summary>
        /// <returns>Экземпляр <see cref="Contact"/>, хранящий данные о контакте</returns>
        static public ObservableCollection<Contact> ReadContacts() 
        {
            ObservableCollection<Contact> data;
            try
            {
                data = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(File.ReadAllText(_path + _filename));
            }
            catch
            {
                return data = new ObservableCollection<Contact>();
            }

            return data;
        }
    }
}
