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
            Model.Validator.AssertValueInRange(value, 0, 24, "Time.Hours");

            _hours = value;
        }

        public void SetMinutes(int value) 
        {
            Model.Validator.AssertValueInRange(value, 0, 60, "Time.Minutes");

            _minutes = value;
        }

        public void SetSeconds(int value)
        {
            Model.Validator.AssertValueInRange(value, 0, 60, "Time.Seconds");

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
