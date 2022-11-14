using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class Bullet : GameObject
    {
        private const int MOVEMENT = 5;
        private Shooting shooting;

        public Bullet(Rectangle rectangle, Color colour, Size boundaries, Graphics graphics, Point velocity) : base(rectangle, colour, boundaries, graphics, velocity)
        {
        }

        public override void Draw()
        {
            graphics.FillRectangle(brush, rectangle);
        }

        public override void Move()
        {
            rectangle.Y -= velocity.Y;
        }

        public Shooting Shooting { get => shooting; set => shooting = value; }
    }
}
