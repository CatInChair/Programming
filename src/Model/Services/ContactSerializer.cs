using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace Model.Services
{
    /// <summary>
    /// Сервисный класс, используемый для сохранения и чтения контактов
    /// </summary>
    public class ContactSerializer
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
        /// Сохраняет данные коллекции контактов в файл в формате JSON
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
        /// Читает данные контактов из файла
        /// </summary>
        /// <returns>Экземпляр <see cref="ObservableCollection{Contact}"/>, хранящий данные о контактах</returns>
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
