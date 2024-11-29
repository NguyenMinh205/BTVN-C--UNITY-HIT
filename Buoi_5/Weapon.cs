using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Buoi5
{
    internal class Weapon
    {
        protected string name;
        protected double attack;
        protected int rangeAttack;

        public Weapon(string name, double attack, int rangeAttack)
        {
            this.name = name;
            this.attack = attack;
            this.rangeAttack = rangeAttack;
        }

        public string GetName() { return name; }
        public double GetAttack() { return attack; }
        public int GetRangeAttack() { return rangeAttack; }

    }
}
