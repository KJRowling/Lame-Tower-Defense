using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class StrongInvader : Invader
    {

        //subclasses can't change the interfaces that they override
        public override int health { get; protected set; } = 5;
        public StrongInvader(Path path) : base(path)
        { }

    }
}
