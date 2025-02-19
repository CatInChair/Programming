using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationalSystem.Model
{
    /// <summary>
    /// Статический класс, содержащий методы для приведения экземпляров <see cref="AirRoute"/> в строки и наоборот.
    /// </summary>
    static public class Serializer
    {
        /// <summary>
        /// Преобразует <see cref="List{AirRoute}"/> в строку, содержащую информацию о всех объектах, находящихся в переданном списке.
        /// </summary>
        /// <param name="routes">Список экземпляров <see cref="AirRoute"/></param>
        /// <returns>Возвращает строку с информацией обо всех экземплярах <see cref="AirRoute"/> в переданном списке.</returns>
        static public string Serialize(List<AirRoute> routes)
        {
            return String.Join("\n", routes.Select(r => $"{r.DeparturePoint};{r.ArrivalPoint};{r.DepartureTime};{r.Duration};{r.Type}"));
        }

        /// <summary>
        /// Преобразует строку, хранящую информацию об экземплярах <see cref="AirRoute"/>, в <see cref="List{AirRoute}"/>.
        /// </summary>
        /// <param name="data">Строка, содержащая сериализованные экземпляры <see cref="AirRoute"/>.</param>
        /// <returns></returns>
        static public List<AirRoute> Deserialize(string data)
        {
            List<AirRoute> routes = new List<AirRoute>();

            foreach (string entry in data.Split('\n'))
            {
                try 
                {
                    AirRoute route = new AirRoute();
                    string[] properties = entry.Split(';');

                    route.DeparturePoint = properties[0];
                    route.ArrivalPoint = properties[1];
                    route.DepartureTime = DateTime.Parse(properties[2]);
                    route.Duration = Int32.Parse(properties[3]);
                    route.Type = Int32.Parse((properties[4]));

                    routes.Add(route);
                    Console.WriteLine(route.ToString());
                } catch { }
            }

            return routes;
        }
    }
}
