using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal class GameManager
    {
        protected GridManager _gridManager;
        protected int xWide;
        protected int yHigh;

        List<Enemy> enemyList = new List<Enemy>();

        protected Player player = new Player();

        protected bool isTurnPlayer = true;

        public GameManager() { }

        public GameManager(Player player, List<Enemy> enemies, int xWide, int yHigh)
        {
            this.player = player;
            this.xWide = xWide;
            this.yHigh = yHigh;
            this.enemyList = enemies;
            _gridManager = new GridManager(player, enemyList, xWide, yHigh);
        }

        //public GameManager (int xWide, int yHigh)
        //{
        //    this.xWide = xWide;
        //    this.yHigh = yHigh;
        //    gridManager = new GridManager(xWide, yHigh);
        //}
        
        public void StartBattle() //Bắt đầu game, khởi tạo các giá trị ban đầu để game chạy
        {
            Console.WriteLine("Game đang chạy");
            Console.WriteLine("Vũ khí của bạn là: " + player.GetWeapon().GetName());
            _gridManager.SpawnTile(xWide, yHigh);
            while (CheckWinOrLost())
            {
                Console.WriteLine("Máu của player: " + player.getHealthPoint());
                foreach (Enemy enemy in enemyList)
                {
                    Console.WriteLine("Máu của enemy: " + enemy.getHealthPoint());
                }
                //_gridManager.addCharacterToTile(xWide, yHigh);
                _gridManager.UpdateGrid(enemyList, player);
                _gridManager.DrawGrid(xWide, yHigh);
                if (isTurnPlayer)
                {
                    TurnPlayer();
                    if (!CheckWinOrLost())
                    {
                        if (enemyList.Count <= 0)
                        {
                            Console.WriteLine("Bạn đã thắng.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Bạn đã thua.");
                            return;
                        }
                    }
                }
                else
                {
                    TurnEnemy();
                    if (!CheckWinOrLost()) 
                    {
                        if (player.getHealthPoint() <= 0)
                        {
                            Console.WriteLine("Bạn đã thua.");
                            return;
                        }
                    }
                }
                Console.Clear();   
            }
        }

        public void SpawnEntity()
        {
            
        }

        public void TurnPlayer()
        {
            if (isTurnPlayer)
            {
                Console.WriteLine("Lượt người chơi.");
                player.Move(xWide, yHigh,_gridManager.getGrid());
                player.CheckRangeAttack(xWide, yHigh, _gridManager.getGrid());
                isTurnPlayer = false;
            }
        }

        public void TurnEnemy()
        {
            if (!isTurnPlayer)
            {
                Console.WriteLine("Lượt quái.");
                foreach (Enemy enemy in enemyList)
                {
                    enemy.Move(xWide, yHigh, _gridManager.getGrid());
                    enemy.CheckRangeAttack(xWide, yHigh, _gridManager.getGrid());
                }
                isTurnPlayer = true;
            }
        }

        public bool CheckWinOrLost()
        {
            if (player.getHealthPoint() <= 0)
            {
                return false;
            } 

            foreach (Enemy enemy in enemyList)
            {
                if (enemy.getHealthPoint() <= 0)
                {
                    enemyList.Remove(enemy);
                }
            }

            if (enemyList.Count <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
