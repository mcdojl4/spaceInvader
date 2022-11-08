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
        private const int mShip_Y = 480;
        private const int mShip_WIDTH = 40;
        private const int mShip_HEIGHT = 60;

        //Enemy vars
        private const int enemy_VEL = 10;
        private const int enemy_X = 375;
        private const int enemy_Y = 500;
        private const int enemy_WIDTH = 50;
        private const int enemy_HEIGHT = 50;

        private const int RGB = 256;

        private Random random;
        private MotherShip motherShip;
        //private Enemy enemy;
        private Size boundaries;


        private List<Enemy> enemies;

        /// <summary>
        /// Controller's constructor
        /// </summary>
        /// <param name="boundries">This refers to the client size</param>
        /// <param name="graphics">This refers to the graphics object</param>
        public Controller(Size boundaries, Graphics graphics)
        {
            this.boundaries = boundaries;
            random = new Random();
            motherShip = new MotherShip(
                new Rectangle(mShip_X, mShip_Y, mShip_WIDTH, mShip_HEIGHT),
                Color.White, boundaries, graphics, new Point(mShip_VEL, mShip_VEL));

            enemies = new List<Enemy>();
            int y = 20;
            
            for (int i = 0; i < 4; i++)
            {
                int x = 20;
                for (int j = 0; j < 10; j++)
                {
                    enemies.Add(new Enemy(new Rectangle(x, y, enemy_WIDTH, enemy_HEIGHT),
                    Color.FromArgb(random.Next(RGB), random.Next(RGB), random.Next(RGB)),boundaries, graphics, 
                    new Point(enemy_VEL, enemy_VEL)));

                    x += 60;
                }
                y += 60;
            }


        }

        /// <summary>
        /// This method manages the application's game loop
        /// </summary>

        public void Run()
        {
            MoveEnemies();
            DrawEnemies();

            motherShip.Draw();
        }

        public void MoveEnemies()
        {
            if (((enemies[enemies.Count - 1].Rectangle.X + 50) > boundaries.Width) || (enemies[0].Rectangle.X < 0))
            {
                ReverseDirection();
            }

            MoveEnemiesHorizontal();
        }

        public void ReverseDirection()
        {
            foreach (Enemy eachEnemy in enemies)
            {
                eachEnemy.Velocity = new Point(eachEnemy.Velocity.X * -1, eachEnemy.Velocity.Y);
            }
        }

        public void MoveEnemiesHorizontal()
        {
            foreach (Enemy eachEnemy in enemies)
            {
                eachEnemy.Move();
            }
        }

        public void DrawEnemies()
        {
            foreach (Enemy eachEnemy in enemies)
            {
                eachEnemy.Draw();

            }
        }

        /// <summary>
        /// This method manages the paddle's movement
        /// </summary>
        /// <param name="direction"></param>
        public void MovePaddleByKeys(Direction direction)
        {
            motherShip.Direction = direction;
            motherShip.Move();
        }

    }
}
