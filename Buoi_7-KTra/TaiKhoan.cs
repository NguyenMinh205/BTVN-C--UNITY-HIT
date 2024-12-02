using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_ktra
{
    internal class TaiKhoan
    {
        protected static int TAOTKTUDONG = 1;
        protected string maTK;
        protected double soDu;

        public TaiKhoan() { }
        public TaiKhoan(double soDu)
        {
            maTK = Convert.ToString(TAOTKTUDONG);
            this.soDu = soDu;
            TAOTKTUDONG++;
        }

        public string GetMaTK() { return maTK; }
        public double GetSoDu() { return soDu; }
        public void SetSoDu(double soDu) { this.soDu = soDu; }

        public void NapTien(double tienNap)
        {
            if (tienNap <= 0)
            {
                Console.WriteLine("Số tiền nạp vào không hợp lệ.");
                return;
            }    
            else
            {
                soDu += tienNap;
                Console.WriteLine("Đã nạp tiền vào tài khoản " + maTK + ". Số dư hiện tại: " + soDu);
                return;
            }
        }

        public void RutTien(double tienRut)
        {
            if (tienRut <= 0)
            {
                Console.WriteLine("Số tiền muốn rút không hợp lệ.");
                return;
            }    
            else
            {
                if (soDu - tienRut <= 0)
                {
                    Console.WriteLine("Số tiền muốn rút không hợp lệ.");
                    return;
                }
                else
                {
                    soDu -= tienRut;
                    Console.WriteLine("Đã rút tiền vào tài khoản " + maTK + ". Số dư hiện tại: " + soDu);
                    return;
                }  
            }
        }
    }
}
