using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal abstract class Character
    {
        protected int posX;
        protected int posY;
        protected double damage;
        protected int rangeAttack;
        protected double healthPoint;

        public Character() { }

        public Character(int posX, int posY, double damage, int rangeAttack, int healthPoint)
        {
            this.posX = posX;
            this.posY = posY;
            this.damage = damage;
            this.rangeAttack = rangeAttack;
            this.healthPoint = healthPoint;
        }

        public int getX() { return posX; }
        public int getY() { return posY; }
        public double getDamage() { return damage; }
        public int getRangeAttack() { return rangeAttack; }
        public double getHealthPoint() { return healthPoint; }

        public void setPosX(int posX) { this.posX = posX; }
        public void setPosY(int posY) { this.posY = posY; }
        public void setDamage(double damage) { this.damage = damage; }
        public void setRangeAttack(int rangeAttack) { this.rangeAttack = rangeAttack; }
        public void setHealthPoint(double healthPoint) { this.healthPoint = healthPoint; }

        public abstract void Move(int width, int height, Tile[,] grid);
        public void TakeDamage(double damage, Character target)
        {
            target.healthPoint -= damage;
        }
        public void Attack(Character target)
        {
            TakeDamage(damage, target);
        }
        public abstract void CheckRangeAttack(int width, int height, Tile[,] grid);

        public bool isPlayer(Character character)
        {
            if (character is  Player) return true;
            else return false;
        }
    }
}
