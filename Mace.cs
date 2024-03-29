﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HeadFirst__Laboratory2
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            if (DamageEnemy(Direction.Down, 80, 6, random)) { }
            else if (DamageEnemy(Direction.Left, 80, 6, random)) { }
            else if (DamageEnemy(Direction.Up, 80, 6, random)) { }
            else
                DamageEnemy(Direction.Right, 80, 6, random);
        }
    }
}
