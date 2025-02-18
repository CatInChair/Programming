namespace Programming.Model
{
    /// <summary>
    /// Класс, содержащий информацию об авиа-перелете.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Пункт вылета.
        /// </summary>
        public string DeparturePoint;
        /// <summary>
        /// Пункт прибытия.
        /// </summary>
        public string DestinationPoint;
        /// <summary>
        /// Длительность полета.
        /// </summary>
        public int FlightDuration
        {
            get
            {
                return FlightDuration;
            }
            set
            {
                Model.Validator.AssertOnPositiveValue(value, "Route.FlightDuration");

                FlightDuration = value;
            }
        }
       
        /// <summary>
        /// Конструктор класса <see cref="Route"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт вылета.</param>
        /// <param name="destinationPoint">Пункт прибытия.</param>
        /// <param name="duration">Длительность полета.</param>
        public Route(string departurePoint, string destinationPoint, int duration) 
        { 
            DestinationPoint = destinationPoint;
            DeparturePoint = departurePoint;
            FlightDuration = duration;
        }

        /// <summary>
        /// Конструктор пустого экземпляра класса <see cref="Route"/>.
        /// </summary>
        public Route() { }
    }
}
