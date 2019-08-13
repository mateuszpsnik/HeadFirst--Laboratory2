using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HeadFirst__Laboratory2
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }
        public override void Move(Random random)
        {
            while (HitPoints > 0)
            {
                if (random.Next(0, 3) == 1)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                else
                {
                   //stay in place
                }
                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }
    }
}
