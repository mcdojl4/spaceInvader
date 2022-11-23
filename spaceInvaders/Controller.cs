using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spaceInvaders
{
    public class Controller
    {
        //Motherships vars
        private const int mShip_VEL = 20;
        private const int mShip_X = (1000 / 2) - (40 / 2);
        private const int mShip_Y = 690;
        private const int mShip_WIDTH = 40;
        private const int mShip_HEIGHT = 60;

        //Enemy vars
        private const int enemy_VEL_X = 10;
        private const int enemy_VEL_Y = 1;
        private const int enemy_X = 375;
        private const int enemy_Y = 500;
        private const int enemy_WIDTH = 50;
        private const int enemy_HEIGHT = 50;

        //Bullet vars
        private const int bullet_VEL_X = 200;
        private const int bullet_VEL_Y = 1;
        private const int bullet_X = 0;
        private const int bullet_Y = (mShip_Y - bullet_HEIGHT);
        private const int bullet_WIDTH = 10;
        private const int bullet_HEIGHT = 15;

        private const int RGB = 256;
        //Sets class vars
        private Random random;
        private MotherShip motherShip;
        private Size boundaries;

        private List<Bullet> bullets;
        private List<Enemy> enemies;
        private Graphics graphics;

        // Controller's constructor
        public Controller(Size boundaries, Graphics graphics)
        {
            this.boundaries = boundaries;
            this.graphics = graphics;
            random = new Random();
            motherShip = new MotherShip(
                new Rectangle(mShip_X, mShip_Y, mShip_WIDTH, mShip_HEIGHT),
                Color.White, boundaries, graphics, new Point(mShip_VEL, mShip_VEL));

            enemies = new List<Enemy>();
            bullets = new List<Bullet>();
            
            //Spawns players in for loops
            int y = 20;
            for (int i = 0; i < 4; i++)
            {
                int x = 20;
                for (int j = 0; j < 10; j++)
                {
                    enemies.Add(new Enemy(new Rectangle(x, y, enemy_WIDTH, enemy_HEIGHT),
                    Color.FromArgb(random.Next(RGB), random.Next(RGB), random.Next(RGB)), boundaries, graphics,
                    new Point(enemy_VEL_X, enemy_VEL_Y)));

                    x += 60;
                }
                y += 60;
            }


        }

        // This method manages the application's game loop
        public void Run()
        {
            DrawEnemies();
            MoveEnemies();


            //if (enemies.CheckforCollision(bullets))
            //{
            //    //Add to score
            //}

            motherShip.Draw();

            DrawBullets();
            BulletMove();
        }

        //Enemies move and collision mechanics
        public void MoveEnemies()
        {
            if (((enemies[enemies.Count - 1].Rectangle.X + 50) > boundaries.Width) || (enemies[0].Rectangle.X < 0))
            {
                ReverseDirection();
                MoveEnemiesVertical();
            }

            MoveEnemiesHorizontal();
        }

        //Used when enemy hits edge and changes direction
        public void ReverseDirection()
        {
            foreach (Enemy eachEnemy in enemies)
            {
                eachEnemy.Velocity = new Point(eachEnemy.Velocity.X * -1, eachEnemy.Velocity.Y);
            }
        }

        //Moves enemy across
        public void MoveEnemiesHorizontal()
        {
            foreach (Enemy eachEnemy in enemies)
            {
                eachEnemy.Move();
            }
        }

        //Moves enemy down
        public void MoveEnemiesVertical()
        {
            foreach (Enemy eachEnemy in enemies)
            {
                eachEnemy.Move_Down();
            }
        }

        //Draws enemies
        public void DrawEnemies()
        {
            foreach (Enemy eachEnemy in enemies)
            {
                eachEnemy.Draw();

            }
        }

        //Bullet mechanics
        //Draws bullets
        public void DrawBullets()
        {
            foreach (Bullet eachBullet in bullets)
            {
                eachBullet.Draw();
            }
        }

        //Makes bullet move
        public void BulletMove()
        {
            foreach (Bullet eachBullet in bullets)
            {
                eachBullet.Move();
            }
        }

        //Checks for collision between bullets and enemy
        public bool CheckForCollisions(List<Bullet> bullets)
        {

            bool collision = false;

            foreach(Enemy eachEnemy in enemies)
            {
                foreach (Bullet eachBullet in bullets)
                {
                    if (eachEnemy.HitMe(eachBullet))
                    {
                        //eachEnemy.Alive = false;
                        //eachEnemy.Alive = false;

                        //Remove at
                        collision = true;
                        break;
                    }
                }
            }
            return collision;
        }

        // This method manages the motherships movement
        public void MoveMothershipByKeys(Direction direction)
        {
            motherShip.Direction = direction;
            motherShip.Move();
        }

        //This method adds a bullet when space is pressed
        public void ShootBullet()
        {
            bullets.Add(new Bullet(
                new Rectangle(motherShip.Rectangle.X + (mShip_WIDTH / 2), bullet_Y, bullet_WIDTH, bullet_HEIGHT),
                Color.White,
                boundaries,
                graphics,
                new Point(20, 20)));
        }
    }
}
