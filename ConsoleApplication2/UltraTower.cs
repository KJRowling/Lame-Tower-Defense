using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class UltraTower : Tower
    {
        protected override int Range { get; } = 1;
        protected override int Power { get; } = 5;
        protected override double Accuracy { get; } = .99;
        
        //use new instead of override rarely if you don't want to override the member to get rid of the "hidden member" warning.
        public UltraTower(MapLocation location) : base(location)
        {
        }
            
        //add logic to make sure tower can't be placed on path
    }
}
