using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal class GridManager
    {
        protected int xWide;
        protected int yHigh;

        List<Enemy> enemyList = new List<Enemy>();

        protected Player player;

        protected Tile[,] grid;

        public Tile[,] getGrid() { return grid; }

        public GridManager (Player player, List<Enemy> enemies, int xWide, int yHigh)
        {
            this.xWide = xWide;
            this.yHigh = yHigh;
            this.player = player;
            this.enemyList = enemies;
            grid = new Tile[xWide, yHigh];
        }

        public void SpawnTile(int x, int y)
        {
            for (int tileX = 0; tileX < x; tileX++)
            {
                for (int tileY = 0; tileY < y; tileY++)
                {
                    grid[tileX, tileY] = new Tile(tileX, tileY);
                }
            }
        }

        //public void addCharacterToTile(int x, int y)
        //{
        //    for (int tileX = 0; tileX < x; tileX++)
        //    {
        //        for (int tileY = 0; tileY < y; tileY++)
        //        {
        //            if (player.getX() == tileX  && player.getY() == tileY) 
        //            {
        //                grid[tileX, tileY].setIsContains(player);
        //                continue;
        //            }
        //            foreach (Enemy enemy in enemyList)
        //            {
        //                if (enemy.getX() == tileX && enemy.getY() == tileY)
        //                {
        //                    grid[tileX, tileY].setIsContains(enemy);
        //                }
        //            }
        //        }
        //    }
        //}

        public void UpdateGrid(List<Enemy> enemyList, Player player)
        {
            foreach (Tile tile in grid)
            {
                tile.setIsContains(null);
            }    

            foreach (Enemy enemy in enemyList)
            {
                grid[enemy.getX(), enemy.getY()].setIsContains(enemy);
            }

            grid[player.getX(), player.getY()].setIsContains(player);
        }

        public void DrawGrid(int x, int y)
        {
            for (int tileX = 0; tileX < x; tileX++)
            {
                for (int tileY = 0; tileY < y; tileY++)
                {
                    if (grid[tileX, tileY].IsOccupied())
                    {

                        if (grid[tileX, tileY].CheckPlayer())
                        {
                            Console.Write("0 ");
                        }
                        else
                        {
                            Console.Write("1 ");
                        }
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
