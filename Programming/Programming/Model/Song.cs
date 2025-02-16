using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        private string _name;
        private string _author;
        private int _duration;

        public string GetName()
        {
            return _name;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public int GetDuration() 
        {
            return _duration;
        }

        public void SetName(string value)
        {
            _name = value;
        }
        public void SetAuthor(string value)
        {
            _author = value;
        }
        public void SetDuration(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Duration must be more than 0");
            }

            _duration = value;
        }

        public Song(string name, string author, int duration)
        {
            this.SetName(name);
            this.SetAuthor(author);
            this.SetDuration(duration);
        }

        public Song() { }
    } 
}
