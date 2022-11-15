using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class Enemy : GameObject
    {
        private bool alive;

        public Enemy(Rectangle rectangle, Color colour, Size boundaries, Graphics graphics, Point velocity) : base(rectangle, colour, boundaries, graphics, velocity)
        {
            this.alive = alive;
        }

        public override void Draw()
        {
            graphics.FillRectangle(brush, rectangle);
        }

        public override void Move()
        {
            rectangle.X += velocity.X;
        }

        public void Move_Down()
        {
            rectangle.Y += 20;
        }

        public bool HitMe(Bullet bullet)
        {
            bool collided = false;

            int myLeft = rectangle.X;
            int myRight = rectangle.X + 50;
            int myTop = rectangle.Y;
            int myBottom = rectangle.Y + 50;

            int hisLeft = bullet.Rectangle.X;
            int hisRight = bullet.Rectangle.X + 10;
            int hisTop = bullet.Rectangle.Y;
            int hisBottom = bullet.Rectangle.Y + 15;

            if ((myBottom < hisTop)||(myTop > hisTop)||(myRight < hisLeft)||(myLeft > hisRight))
            {
                collided = true;
            }

            return collided;
        }

        protected bool Alive { get => alive; set => alive = value; }
    }
}
