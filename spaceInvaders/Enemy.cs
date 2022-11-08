using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class Enemy : GameObject
    {

        public int ePosition_X;
        public int ePosition_X_2;


        public Enemy(Rectangle rectangle, Color colour, Size boundaries, Graphics graphics, Point velocity) : base(rectangle, colour, boundaries, graphics, velocity)
        {
        }

        public override void Draw()
        {
            graphics.FillRectangle(brush, rectangle);
        }

        public override void Move()
        {
            rectangle.X += velocity.X;
        }

        public void Collision()
        {
            velocity.X *= -1;
        }

        public int ePosition()
        {
            ePosition_X = rectangle.X;

            return ePosition_X;
        }
    }
}
