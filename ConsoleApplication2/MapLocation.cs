using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    //inherit from point
    class MapLocation : Point
    {
    
        //call base class constructor
        public MapLocation(int x, int y, Map map) : base (x, y)
        {
            //determine if map location being constructed is on map
            if (!map.OnMap(this)) // this = current object - object is not fully constructed until object is returned
            {
                
                    throw new OutOfBoundsException(x + "," + y + " is outside the boundary of the map");

                


            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
