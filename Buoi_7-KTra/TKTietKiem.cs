using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_ktra
{
    internal class TKTietKiem : TaiKhoan
    {
        private double laiSuat;

        public TKTietKiem() { }
        public TKTietKiem(double soDu, double laiSuat) : base(soDu)
        {
            this.laiSuat = laiSuat;
        }

        public double GetLaiSuat() { return laiSuat; }
        public void SetLaiSuat(double laiSuat) { this.laiSuat = laiSuat; }
    }
}
