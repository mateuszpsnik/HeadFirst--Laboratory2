using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HeadFirst__Laboratory2
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 40, 3, random))
            {
                switch (direction)
                {
                    case Direction.Up:
                        direction = Direction.Right;
                        break;
                    case Direction.Right:
                        direction = Direction.Down;
                        break;
                    case Direction.Down:
                        direction = Direction.Left;
                        break;
                    case Direction.Left:
                        direction = Direction.Up;
                        break;
                    default: break;
                }
                if (!DamageEnemy(direction, 40, 3, random))
                {
                    switch (direction)
                    {
                        case Direction.Up:
                            direction = Direction.Right;
                            break;
                        case Direction.Right:
                            direction = Direction.Down;
                            break;
                        case Direction.Down:
                            direction = Direction.Left;
                            break;
                        case Direction.Left:
                            direction = Direction.Up;
                            break;
                        default: break;
                    }
                    DamageEnemy(direction, 40, 3, random);
                }
            }
        }
    }
}
