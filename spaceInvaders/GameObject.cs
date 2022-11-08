using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public abstract class GameObject
    {
        protected Rectangle rectangle;
        protected Color colour;
        protected Size boundries;
        protected Graphics graphics;
        protected Point velocity;
        protected Brush brush;

        public GameObject(Rectangle rectangle, Color colour, Size boundries, Graphics graphics, Point velocity)
        {
            this.rectangle = rectangle;
            this.boundries = boundries;
            this.graphics = graphics;
            this.velocity = velocity;

            brush = new SolidBrush(colour);
        }

        public abstract void Draw();

        public abstract void Move();
    }
}
