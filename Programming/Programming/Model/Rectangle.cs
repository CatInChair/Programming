using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;
        private Point2D _center;
        public int Id { get; }  

        private static int _allRectanglesCount;

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
        public Point2D GetCenter()
        {
            return _center;
        }
        public static int AllRectanglesCount()
        {
            return _allRectanglesCount;
        }

        public void SetLength(double value)
        {
            Model.Validator.AssertOnPositiveValue(value, "Rectangle.Length");

            _length = value;
        }
        public void SetWidth(double value)
        {
            Model.Validator.AssertOnPositiveValue(value, "Rectangle.Width");

            _width = value;
        }
        public void SetColor(string value) 
        { 
            _color = value;
        }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            this.SetLength(length);
            this.SetWidth(width);
            this.SetColor(color);
            _center = center;
            Id = AllRectanglesCount();

            _allRectanglesCount++;
        }

        public Rectangle() 
        {
            _allRectanglesCount++;
        }
    }
}
