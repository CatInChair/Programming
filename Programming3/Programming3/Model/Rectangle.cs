using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming3.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;

        public double GetLength()
        {
            return _length;
        }
        public double GetWidth() 
        { 
            return _width; 
        }
        public string GetColor() 
        { 
            return _color; 
        }

        public void SetLength(double value)
        {
            if (value < 0.0)
            {
                throw new ArgumentException("Length must be more than 0.0");
            }

            _length = value;
        }
        public void SetWidth(double value)
        {
            if (value < 0.0)
            {
                throw new ArgumentException("Width must be more than 0.0");
            }

            _width = value;
        }
        public void SetColor(string value) 
        { 
            _color = value;
        }

        public Rectangle(double length, double width, string color)
        {
            this.SetLength(length);
            this.SetWidth(width);
            this.SetColor(color);
        }

        public Rectangle() { }
    }
}
