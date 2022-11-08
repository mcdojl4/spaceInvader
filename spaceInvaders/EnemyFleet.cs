using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvaders
{
    public class EnemyFleet
    {
        //Enemy vars
        private const int enemy_VEL = 20;
        private const int enemy_X = 375;
        private const int enemy_Y = 500;
        private const int enemy_WIDTH = 30;
        private const int enemy_HEIGHT = 50;

        private List<Enemy> enemies;

        public EnemyFleet(List<Enemy> enemies)
        {
            this.enemies = enemies;

            enemies = new List<Enemy>();
        }

        public void Draw()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    enemies.Add(new Enemy(new Rectangle(i + 20, j + 20, enemy_WIDTH, enemy_HEIGHT),
                    Color.Blue,
                    boundries,
                    graphics,
                    new Point(enemy_VEL, enemy_VEL)));

                }
            }
        }
    }
}
