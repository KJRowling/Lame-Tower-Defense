using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class ShieldedInvader : Invader
    {

        private static System.Random _random = new System.Random();
            

        public ShieldedInvader(Path path) : base(path) { }

        //override and use base class decreaseHealth function
        public override void decreaseHealth(int factor)
        {
            if(_random.NextDouble() < .5)
            {
                base.decreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine("Shot at a shielded invader but it took no damage.");
            }
        }
    }
}
