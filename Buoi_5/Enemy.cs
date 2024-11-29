using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal class Enemy : Character
    {
        protected Tile[,] grid;
        public Enemy() { }

        public Enemy(int posX, int posY, double damage, int rangeAttack, int healthPoint) :
            base(posX, posY, damage, rangeAttack, healthPoint)
        { }

        //public override bool isPlayer() { return false; }

        public override void Move(int width, int height, Tile[,] grid)
        {
            Random random = new Random();
            int direction = random.Next(1, 5);
            if (direction == 1 && posY > 0 && !grid[posX, posY - 1].IsOccupied())
                this.posY -= 1; //sang trái
            else if (direction == 2 && posX < width - 1 && !grid[posX, posY + 1].IsOccupied())
                this.posY += 1; //sang phải
            else if (direction == 3 && posX > 0 && !grid[posX - 1, posY].IsOccupied())
                this.posX -= 1; //lên trên
            else if (direction == 4  && posX < height - 1 && !grid[posX + 1, posY].IsOccupied())
                this.posX += 1; //xuống dưới
        }

        public override void CheckRangeAttack(int width, int height, Tile[,] grid)
        {
            for (int x = -rangeAttack; x <= rangeAttack; x++)
            {
                int targetX = this.posX + x;
                if (targetX >= 0 && targetX < height)
                {

                    if (grid[targetX, this.posY].IsOccupied() == true && grid[targetX, this.posY].getIsContains() is Player)
                    {
                        Attack(grid[targetX, this.posY].getIsContains());
                        return;
                    }
                }
            }
            for (int y = -rangeAttack; y <= rangeAttack; y++)
            {
                int targetY = this.posY + y;
                if (targetY >= 0 && targetY < height)
                {
                    if (grid[this.posX, targetY].IsOccupied() == true && grid[this.posX, targetY].getIsContains() is Player)
                    {
                        Attack(grid[this.posX, targetY].getIsContains());
                        return;
                    }
                }
            }
        }

        public string toString()
        {
            return "PosX: " + this.posX + "PosY: " + this.posY + "damage " + this.damage + " range attack" + this.rangeAttack;
        }
    }
}
