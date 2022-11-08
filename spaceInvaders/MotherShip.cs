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

        public MotherShip(Rectangle rectangle, Color colour, Size boundries, Graphics graphics, Point velocity) : base(rectangle, colour, boundries, graphics, velocity)
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
                    rectangle.X -= MOVEMENT;
                    break;
                case Direction.RIGHT:
                    rectangle.X += MOVEMENT;
                    break;
                default:
                    break;
            }
        }
        public Direction Direction { get => direction; set => direction = value; }
    }
}
