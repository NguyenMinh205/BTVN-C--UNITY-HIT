using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal class ActiveGame
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int randomPosX = new Random().Next(0, 10);
            int randomPosY = new Random().Next(0, 10);
            int randomHealth = new Random().Next(5, 9);

            List<Weapon> weapons = new List<Weapon>()
            {
                new Weapon("kiếm", 2, 2),
                new Weapon("súng", 1, 3),
                new Weapon("tay", 0.5, 1)
            };

            int randomWeapon = new Random().Next(0, weapons.Count);

            Player player = new Player(randomPosX, randomPosY, 0, 0, 10, weapons[randomWeapon]);
            //Tạo một list random enemy có số lượng nhập từ bàn phím hay độ khó (Phát triển sau khi hoanf thành)
            List<Enemy> enemies = new List<Enemy>() {
                new Enemy(new Random().Next(0, 10), new Random().Next(0, 10), 1.5, 1, randomHealth),
                new Enemy(new Random().Next(0, 10), new Random().Next(0, 10), 1, 2, randomHealth)
            };

            GameManager gameManager = new GameManager(player, enemies, 10, 10);
            gameManager.StartBattle();
        }
    }
}
