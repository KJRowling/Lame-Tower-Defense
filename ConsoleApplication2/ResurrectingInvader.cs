using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    //try putting properties above constructor and methods below it
    //composition
    class ResurrectingInvader : IInvader //no base class of invader
    {
        private BasicInvader _incarnation1;
        private StrongInvader _incarnation2;

        public ResurrectingInvader(Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new StrongInvader(path);
        }


        public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;
    

        public void Move()
        {
        _incarnation1.Move();
        _incarnation2.Move();
    }


        public int health => _incarnation1.IsNeutralized ? _incarnation2.health : _incarnation1.health;
        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;


        public void decreaseHealth(int factor)
        {
            if(!_incarnation1.IsNeutralized)
            {
                _incarnation1.decreaseHealth(factor);
            }
            else
            {
                _incarnation2.decreaseHealth(factor);
            }
        }


        public bool IsNeutralized => _incarnation1.IsNeutralized && _incarnation2.IsNeutralized;

        public bool IsActive => !(IsNeutralized || HasScored);


    }
}
