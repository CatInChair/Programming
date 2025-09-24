using System;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий собой кольцо в пространстве.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Экземпляр <see cref="Point2D"/>, представляющий собой центр данного кольца.
        /// </summary>
        public Point2D Center { get; set; }
        /// <summary>
        /// Радиус внутреннего круга.
        /// </summary>
        public double InnerR
        {
            get
            {
                return _innerR;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ring.InnerR");

                if (value >= OuterR)
                {
                    throw new ArgumentException("Ring.InnerR must be less than OuterR value");
                }

                _innerR = value;
            }
        }
        private double _innerR;
        /// <summary>
        /// Радиус внешнего круга.
        /// </summary>
        public double OuterR
        {
            get
            {
                return _outerR;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ring.OuterR");

                if (value <= InnerR)
                {
                    throw new ArgumentException("Ring.OuterR must be more than InnerR value");
                }

                _outerR = value;
            }
        }
        private double _outerR;
        /// <summary>
        /// Площадь данного кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI*(Math.Pow(OuterR, 2.0) - Math.Pow(InnerR, 2.0));
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="Ring"/>
        /// </summary>
        /// <param name="center">Центр кольца, представленный экземпляром <see cref="Point2D"/></param>
        /// <param name="outerR">Радиус внешнего круга.</param>
        /// <param name="innerR">Радиус внутреннего круга.</param>
        public Ring(Point2D center, double outerR, double innerR)
        {
            Center = center;
            OuterR = outerR;
            InnerR = innerR;
        }
    }
}
