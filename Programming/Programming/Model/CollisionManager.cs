using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class CollisionManager
    {
        static public bool IsCollision(Rectangle r1, Rectangle r2)
        {
            return Math.Abs(r1.GetCenter().X - r2.GetCenter().X) < (r1.GetLength() + r2.GetLength())/2 || Math.Abs(r1.GetCenter().Y - r2.GetCenter().Y) < (r1.GetWidth() + r2.GetWidth()) / 2;
        }

        static public bool IsCollision(Ring r1, Ring r2)
        {
            return Math.Sqrt(Math.Pow(r1.Center.X, 2) + Math.Pow(r2.Center.X, 2)) < r1.OuterR + r2.OuterR;
        }
    }
}
