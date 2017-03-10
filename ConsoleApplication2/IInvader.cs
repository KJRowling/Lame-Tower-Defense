using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    //interface implementation
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        void Move();
    }


    interface IInvader : IMappable, IMovable
    {

        int health { get; }
    bool HasScored { get; }


        
        void decreaseHealth(int factor);


        bool IsNeutralized { get; }   //public bool IsNeutralized { get { return health <= 0; } }

        bool IsActive { get; } //return true if invader is not neutralized and has not scored
        //another way to write: public void Move() => _pathStep +=1;
    }
}
