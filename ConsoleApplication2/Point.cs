using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        public readonly int x;
        public readonly int y;

        public Point(int xInput, int yInput)
        {
            x = xInput;
            y = yInput;
        }

        public int DistanceTo(int otherX, int otherY)
        {
            //int xDiff = x - otherX;
            //int yDiff = y - otherY;

            //int xDiffSquared = xDiff * xDiff;
            //int yDiffSquared = yDiff * yDiff;

            int distance = (int)Math.Sqrt(Math.Pow(x - otherX, 2) + Math.Pow(y - otherY, 2));
            //static methods performed directly on method in class without an object of that class
            //Console.WriteLine(distance);

            return distance;
            
        }

        //overload DistanceTo
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.x, point.y);

        }
    }
}
