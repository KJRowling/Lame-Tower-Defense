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


        //Return point of coordinates with System.Object.ToString()
        public override string ToString()
        {
            return x + ", " + y;
        
        }
        public Point(int xInput, int yInput)
        {
            x = xInput;
            y = yInput;
        }

        //override unique hashcode identifier to allow hash code comparisons that are not based on object memory address
        public override int GetHashCode()
        {
            //return hash code that will be equal if two points have the same coordinates
            //return x * 31 + y;

            //it is best to compute hash codes from hash codes of the values we are comparing
            return x.GetHashCode() * 31 + y.GetHashCode();
            
        }
        //allow use of equality operator to determine of two points are the same spot
        //directly comparing the point objects does not work

        public override bool Equals(Object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }

            Point that = obj as Point;

            return this.x == that.x && this.y == that.y;
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
