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
        protected Size boundaries;
        protected Graphics graphics;
        protected Point velocity;
        protected Brush brush;

        public Point Velocity { get => velocity; set => velocity = value; }
        public Rectangle Rectangle { get => rectangle; set => rectangle = value; }

        public GameObject(Rectangle rectangle, Color colour, Size boundaries, Graphics graphics, Point velocity)
        {
            this.rectangle = rectangle;
            this.boundaries = boundaries;
            this.graphics = graphics;
            this.velocity = velocity;

            brush = new SolidBrush(colour);
        }
        //Allows other classes to use this abstract
        public abstract void Draw();

        public abstract void Move();
    }
}
