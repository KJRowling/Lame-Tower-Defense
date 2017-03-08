using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    //create own exception class based on system.exception
    class TowerDefenseException : System.Exception
    {
        public TowerDefenseException(string message) : base(message)
        {
        }

    }

    class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException(string message) : base(message)
        {
        }


        //:base is required here because it is implied that we will cal the default constructor of base class        
        //public OutOfBoundsException() : base()
        //{
        //}
    }



}
