using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class MotherShip : GameObject
    {
        private const int MOVEMENT = 5;
        private Direction direction;

        public MotherShip(Rectangle rectangle, Color colour, Size boundaries, Graphics graphics, Point velocity) : base(rectangle, colour, boundaries, graphics, velocity)
        {
        }



        public override void Draw()
        {
            graphics.FillRectangle(brush, rectangle);
        }

        public override void Move()
        {
            switch (direction)
            {
                case Direction.LEFT:
                    if (rectangle.X > 0) {
                        rectangle.X -= MOVEMENT;
                    }
                    break;
                case Direction.RIGHT:
                    if (rectangle.X + 50 < boundaries.Width)
                    {
                        rectangle.X += MOVEMENT;
                    }
                    break;
                default:

                    break;
            }
        }
        public Direction Direction { get => direction; set => direction = value; }
    }
}
