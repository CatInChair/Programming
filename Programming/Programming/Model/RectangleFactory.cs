using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static public class RectangleFactory
    {
        static public Rectangle Randomize()
        {
            Random random = new Random();

            return new Rectangle(random.Next(50, 100), random.Next(50, 100), new string[] { "Red", "Yellow", "Orange", "Blue" }[random.Next(0, 4)], new Model.Point2D(random.Next(0, 200), random.Next(0, 200)));
        }
    }
}
