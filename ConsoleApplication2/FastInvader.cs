using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense  
{
    class FastInvader : Invader
    {


        virtual protected int StepSize { get; } = 1;
        public FastInvader(Path path) : base(path)
        {}

    }
}
