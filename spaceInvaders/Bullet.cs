using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class Bullet : GameObject
    {
        protected Rectangle rectangle;
        protected bool alive;

        public Bullet(Rectangle rectangle, Color colour, Size boundaries, Graphics graphics, Point velocity) : base(rectangle, colour, boundaries, graphics, velocity)
        {
            this.rectangle = rectangle;
            this.alive = alive;

        }

        //Bullet draw
        public override void Draw()
        {
            graphics.FillRectangle(brush, rectangle);
        }

        //Bullet moves up the screen
        public override void Move()
        {
            rectangle.Y -= velocity.Y;
        }

    }
}
