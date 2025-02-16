using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        public Point2D Center { get; }
        public double InnerR
        {
            get
            {
                return InnerR;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ring.InnerR");

                if (value >= OuterR)
                {
                    throw new ArgumentException("Ring.InnerR must be less than OuterR value");
                }

                InnerR = value;
            }
        }
        public double OuterR
        {
            get
            {
                return OuterR;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ring.OuterR");

                if (value <= InnerR)
                {
                    throw new ArgumentException("Ring.OuterR must be more than InnerR value");
                }

                OuterR = value;
            }
        }
        public double Area
        {
            get
            {
                return Math.PI*(Math.Pow(OuterR, 2.0) - Math.Pow(InnerR, 2.0));
            }
        }

        public Ring(Point2D center, double OuterR, double InnerR)
        {

        }
    }
}
