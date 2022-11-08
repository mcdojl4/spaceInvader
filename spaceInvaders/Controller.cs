using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class Controller
    {
        //Motherships vars
        private const int mShip_VEL = 20;
        private const int mShip_X = 475;
        private const int mShip_Y = 500;
        private const int mShip_WIDTH = 30;
        private const int mShip_HEIGHT = 50;

        private MotherShip motherShip;

        public Controller(Size boundries, Graphics graphics)
        {
            motherShip = new MotherShip(
                new Rectangle(mShip_X, mShip_Y, mShip_WIDTH, mShip_HEIGHT),
                Color.White, boundries, graphics, new Point(mShip_VEL, mShip_VEL));


        }

        public void Run()
        {
            motherShip.Draw();
        }
    }
}
