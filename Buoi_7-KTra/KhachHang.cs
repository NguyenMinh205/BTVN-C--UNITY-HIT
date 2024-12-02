using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_ktra
{
    internal class KhachHang
    {
        private static int TAOTUDONGMAKH = 1;
        private string maKH;
        private string tenKH;
        private List<TaiKhoan> TKs = new List<TaiKhoan>();

        public KhachHang() { }
        public KhachHang(string tenKH)
        {
            this.maKH = "KH" + Convert.ToString(TAOTUDONGMAKH);
            this.tenKH = tenKH;
            TAOTUDONGMAKH++;
        }

        public string GetMaKH() { return maKH; }
        public string GetTenKH() { return tenKH; } 
        public List<TaiKhoan> GetTKS() { return TKs; }
        public void SetTenKH(string tenKH) { this.tenKH = tenKH; }
        public void SetTKHienCo(List<TaiKhoan> TKs) { this.TKs = TKs; }

        public void ThemTK()
        {
            if (TKs.Count() > 4)
            {
                Console.WriteLine("Số tài khoản bạn được sở hữu đã tối đa.");
                return;
            }
            else
            {
                double soDu = 0;
                while (soDu > 0)
                {
                    Console.WriteLine("Nhập số tiền muốn gửi vào tài khoản: ");
                    soDu = Convert.ToDouble(Console.ReadLine());
                    if (soDu <= 0)
                    {
                        Console.WriteLine("Số tiền muốn nạp không hợp lệ. Yêu cầu nhập lại");
                    }    
                }
                TaiKhoan tk = new TaiKhoan(soDu);
                TKs.Add(tk);
            }
        }

        public static void TraTTTaiKhoan(TaiKhoan tk) 
        {
            Console.WriteLine("Mã tài khoản: " + tk.GetMaTK());
            Console.WriteLine("Số dư hiện tại: " + tk.GetSoDu());
        }

        public void InTTKhachHang()
        {
            int dem = 1;
            if (TKs.Count() == 0)
            {
                Console.WriteLine("Khách hàng chưa có tài khoản nào.");
                return;
            }    
            Console.WriteLine("Tên của khách hàng: " + tenKH);
            Console.WriteLine("Tài khoản có mã khách hàng là: " + maKH);
            Console.WriteLine("Khách hàng hiện tại có " + TKs.Count() + " tài khoản.");
            foreach (TaiKhoan k in TKs)
            {
                Console.WriteLine("Tài khoản " + dem++);
                TraTTTaiKhoan(k);
            }    
        }
    }
}
