using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal class Tile
    {
        private Character isContains;
        protected int posX, posY;

        public Tile (int  x, int y)
        {
            this.posX = x;
            this.posY = y;
        }

        public Character getIsContains() { return isContains; }
        public void setIsContains(Character character) { this.isContains = character; }
        public Tile() { }
        public Tile(Character character)
        {
            this.isContains = character;
        }
        public bool IsOccupied()
        {
            return isContains != null;
        }

        public bool CheckPlayer()
        {
            return isContains != null && isContains.isPlayer(isContains);
        }
    }
}
