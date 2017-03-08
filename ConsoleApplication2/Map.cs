using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Map
    {
        public readonly int width;
        public readonly int height;
        
        //constructor
        public Map(int widthCon, int heightCon)
        {
            width = widthCon;
            height = heightCon;
        }

        public bool OnMap (Point point)
        {

            return point.x >= 0 && point.x < width && 
                   point.y >= 0 && point.y < height;

            
            //bool inBounds = point.x >= 0 && point.x < width && point.y >= 0 && point.y < height;


            //bool outOfBounds = point.x < 0 || point.x >= width || point.y < 0 || point.y <= height;

            //return inBounds;
        }
    }

}
