using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class BasicInvader : Invader
    {


        protected override int StepSize { get; } = 2;
        public BasicInvader(Path path) : base(path)
        { }

    }
}
