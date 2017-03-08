using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Tower
    {
        //by convention protected member names start with capital letter
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;
       
        //static member - random is initialized once and used by all tower objects.
        private static readonly System.Random _random = new System.Random();

        protected readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
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
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))  //1 = tower range
                {
                    if (IsSuccessfulShot())
                    {
                        invader.decreaseHealth(Power);//health = 1 //only shoot one invader instead of all invaders.
                        Console.WriteLine("Shot at and hit an invader");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized " + invader.GetType() + " at " + invader.Location);
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
