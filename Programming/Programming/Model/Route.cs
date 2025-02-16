using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Route
    {
        private string _departurePoint;
        private string _destinationPoint;
        private int _flightDuration;

        public string GetDeparturePoint()
        {
            return _departurePoint;
        }
        public string GetDestinationPoint() 
        { 
            return _destinationPoint; 
        }
        public int GetFlightDuration() 
        { 
            return _flightDuration; 
        }

        public void SetDeparturePoint(string value)
        {
            _departurePoint = value;
        }
        public void SetDestinationPoint(string value) 
        { 
            _destinationPoint = value; 
        }
        public void SetFlightDuration(int value) 
        {
            if (value < 0) 
            {
                throw new ArgumentException("FlightDuration must be more than 0");
            }

            _flightDuration = value;
        }

        public Route(string departurePoint, string destinationPoint, int duration) 
        { 
            this.SetDestinationPoint(destinationPoint);
            this.SetDeparturePoint(departurePoint);
            this.SetFlightDuration(duration);
        }

        public Route() { }
    }
}
