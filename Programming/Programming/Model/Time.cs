using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int GetHours() 
        {  
            return _hours; 
        }
        public int GetMinutes() 
        { 
            return _minutes; 
        }
        public int GetSeconds()
        {
            return _seconds;
        }

        public void SetHours(int value)
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentException("Hours must be in the range from 0 to 24");
            }

            _hours = value;
        }

        public void SetMinutes(int value) 
        {
            if (value < 0 || value > 60)
            {
                throw new ArgumentException("Minutes must be in the range from 0 to 60");
            }

            _minutes = value;
        }

        public void SetSeconds(int value)
        {
            if (value < 0 || value > 60)
            {
                throw new ArgumentException("Seconds must be in the range from 0 to 60");
            }

            _seconds = value;
        }

        public Time(int hours, int minutes, int seconds)
        {
            this.SetHours(hours);
            this.SetMinutes(minutes);
            this.SetSeconds(seconds);
        }

        public Time() { }
    }
}
