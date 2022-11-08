using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class Enemy : GameObject
    {
        public Enemy(Rectangle rectangle, Color colour, Size boundaries, Graphics graphics, Point velocity) : base(rectangle, colour, boundaries, graphics, velocity)
        {
        }

        public override void Draw()
        {
            graphics.FillRectangle(brush, rectangle);
        }

        public override void Move()
        {

        }
    }
}
