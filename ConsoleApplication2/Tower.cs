using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;
       
        //static member - random is initialized once and used by all tower objects.
        private static readonly System.Random _random = new System.Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }


        public void FireOnInvaders(Invader[] invaders)
        {
            //int index = 0;
            /*
            while (index < invaders.Length)
            {
                Invader invader = invaders[index];

                //https://msdn.microsoft.com/en-us/library/36x43w8w.aspx
                index++;

            }
            */
            /*
            for(int index = 0; index < invaders.Length; index++)
            {
                Invader invader = invaders[index];
                //do something to invader
            }
            */
            
            foreach(Invader invader in invaders)//do something to each item in collection
            {
                //Do stuff with invader
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))  //1 = tower range
                {
                    if (IsSuccessfulShot())
                    {
                        invader.decreaseHealth(_power);//health = 1 //only shoot one invader instead of all invaders.
                        Console.WriteLine("Shot at and hit an invader");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Kill");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Miss!");
                    }

                        break;//break out of loop so that we only shoot one invader instead of all invaders.

                    }
            }

        }

        //add logic to make sure tower can't be placed on path
    }
}
