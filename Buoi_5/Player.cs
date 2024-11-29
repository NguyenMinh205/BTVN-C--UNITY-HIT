using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Buoi5
{
    internal class Player : Character
    {
        protected Weapon currentWeapon;

        private char _char;

        public Player() { }

        public Player(int posX, int posY, double damage, int rangeAttack, int healthPoint, Weapon weapon) :
            base(posX, posY, damage, rangeAttack, healthPoint)
        {
            this.currentWeapon = weapon;
            this.setRangeAttack(currentWeapon.GetRangeAttack());
            this.setDamage(currentWeapon.GetAttack());
        }

        public Weapon GetWeapon () { return this.currentWeapon; }
        public void setWeapon (Weapon weapon) {  this.currentWeapon = weapon; } 

        //public override bool isPlayer() { return true; }

        public override void Move(int width, int height, Tile[,] grid)
        {
            Console.Write("Nhập hướng đi: ");
            _char = Convert.ToChar(Console.ReadLine());
            if (_char == 'A' && posY > 0 && !grid[posX, posY - 1].IsOccupied())
            {
                posY -= 1; //sang trái
            }
            else if (_char == 'D' && posY < width - 1 && !grid[posX, posY + 1].IsOccupied())
            {
                posY += 1; //sang phải
            }
            else if (_char == 'W' && posX > 0 && !grid[posX - 1, posY].IsOccupied())
            {
                posX -= 1; //lên trên
            }
            else if (_char == 'S' && posX < height - 1 && !grid[posX + 1, posY].IsOccupied())
            {
                posX += 1; //xuống dưới
            }
            else
            {
                _char = ' ';
            }
        }
        public override void CheckRangeAttack(int width, int height, Tile[,] grid)
        {
            for (int x = -rangeAttack; x <= rangeAttack; x++)
            {
                int targetX = this.posX + x;
                if (targetX >= 0 && targetX < height)
                {

                    if (grid[targetX, this.posY].IsOccupied() == true && grid[targetX, this.posY].getIsContains() is Enemy)
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
                    if (grid[this.posX, targetY].IsOccupied() == true && grid[this.posX, targetY].getIsContains() is Enemy)
                    {
                        Attack(grid[this.posX, targetY].getIsContains());
                        return;
                    }
                }
            }

            Console.WriteLine("Không có mục tiêu ở tầm đánh.");
        }
    }
}
