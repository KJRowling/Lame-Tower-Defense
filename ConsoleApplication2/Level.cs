using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Level
    {
        private readonly IInvader[] _invaders;


        public Tower[] Towers { get; set; }
        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }

        //returns true if player wins, false otherwise.
        public bool Play()
        {
            //run until all invaders are neutralized or an invader reaches the end of the path
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                //each tower has opportunity to fire on invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                // count and move the invaders that are still active
                remainingInvaders = 0;
                foreach(IInvader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        remainingInvaders++;
                        invader.Move();
                    }
                    if (invader.HasScored)
                    {
                        return false;
                    }
                        

                }
                
            }


            return true;
        }
    }


}
