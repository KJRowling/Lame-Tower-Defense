using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] _path; //underscore prefixes name of private fields - distinguish instance from method variables

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        //computed property

        public int Length => _path.Length;

        public MapLocation GetLocationAt(int pathStep)
        {

            //ternary if
            //return null if path step is outside of upper bounds of array
            return (pathStep < _path.Length) ? _path[pathStep] : null;

            //
            //int returnValue = (pathStep <_path path.Length) ? _path[pathStep]: null)
            //return returnValue


            //if else
            /*
            if (pathStep < _path.Length)
            {
                return _path[pathStep];
            }
            else
            {
                return null;
            }
            */
            /*
             * //try catch
            try
            {

                return _path[pathStep];
            }
            //index out of range?
            catch(System.IndexOutOfRangeException)
            {
                return null;
            }
            */
        }
    }
}
