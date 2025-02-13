using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming3.Model
{
    public class Film
    {
        private string _name;
        private int _duration;
        private int _releaseYear;
        private string _genre;
        private double _rating;

        public string GetName()
        {
            return _name;
        }
        public int GetDuration() 
        { 
            return _duration;
        }
        public int GetReleaseYear() 
        { 
            return _releaseYear;
        }
        public string GetGenre() 
        { 
            return _genre;
        }
        public double GetRating() 
        { 
            return _rating;
        }

        public void SetName(string value)
        {
            _name = value;
        }
        public void SetDuration(int value) 
        { 
            if (value < 0)
            {
                throw new ArgumentException("Duration must be more than 0");
            }

            _duration = value;
        }
        public void SetReleaseYear(int value)
        {
            if (value < 1900 || value > 2025)
            {
                throw new ArgumentException("ReleaseYear must be more than 1899 and less than 2026");
            }

            _releaseYear = value;
        }
        public void SetGenre(string value)
        {
            _genre = value;
        }
        public void SetRating(double value)
        {
            if (value < 0.0 || value > 10.0)
            {
                throw new ArgumentException("Rating must be more than 0.0 and less than 10.0");
            }

            _rating = value;
        }

        public Film(string name, int duration, int releaseYear, string genre, double rating)
        {
            this.SetName(name);
            this.SetDuration(duration);
            this.SetReleaseYear(releaseYear);
            this.SetGenre(genre);
            this.SetRating(rating);
        }

        public Film() { }
    }
}
