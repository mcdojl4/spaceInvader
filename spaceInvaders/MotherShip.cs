using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class MotherShip : GameObject
    {

        public MotherShip(Rectangle rectangle, Color colour, Size boundries, Graphics graphics, Point velocity) : base(rectangle, colour, boundries, graphics, velocity)
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
