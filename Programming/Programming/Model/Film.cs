using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
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
            Model.Validator.AssertOnPositiveValue(value, "Film.Duration");

            _duration = value;
        }
        public void SetReleaseYear(int value)
        {
            Model.Validator.AssertValueInRange(value, 1900, 2025, "Film.ReleaseYear");

            _releaseYear = value;
        }
        public void SetGenre(string value)
        {
            _genre = value;
        }
        public void SetRating(double value)
        {
            Model.Validator.AssertValueInRange(value, 0.0, 10.0, "Film.Rating");

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
