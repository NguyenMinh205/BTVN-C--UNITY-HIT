using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_ktra
{
    internal class TKVangLai : TaiKhoan
    {
        private TKTietKiem tkTietKiem;
        private double soDuKhaDung;

        public TKVangLai() { }  

        public TKVangLai (double soDu, TKTietKiem tkTietKiem) : base(soDu) 
        { 
            tkTietKiem = tkTietKiem; 
        }

        public double GetSoDuKhaDung () { return soDuKhaDung; }
        public TKTietKiem GetTKTietKiem () { return tkTietKiem; }

        public void CheckSDKD ()
        {
            if (tkTietKiem == null)
            {
                return;
            }

            soDuKhaDung = tkTietKiem.GetSoDu() + soDu;
            SetSoDu(soDuKhaDung);
        }
    }
}
