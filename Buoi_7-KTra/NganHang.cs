using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_ktra
{
    internal class NganHang
    {
        private List<KhachHang> khachHangList = new List<KhachHang>();
        public void ThemKhachHang()
        {
            Console.Write("Nhập tên khách hàng: ");
            string ten = Console.ReadLine();
            Console.Write("Nhập số tiền bạn muốn gửi vào ngân hàng: ");
            double soTien = Convert.ToDouble(Console.ReadLine());
            KhachHang kh = new KhachHang(ten);
            khachHangList.Add(kh);
            Console.WriteLine("Khách hàng đã có thể sử dụng ngân hàng với mã khách hàng là (vui lòng ghi nhớ): " + kh.GetMaKH());
        }

        public void TraTTKhachHang()
        {
            Console.Write("Nhập mã khách hàng muốn tra cứu: ");
            string maKH = Console.ReadLine();
            string num = null;
            foreach (char kt in maKH)
            {
                if (char.IsNumber(kt))
                {
                    num += kt;
                }
            }
            if (num == null || Convert.ToInt32(num) == 0 || Convert.ToInt32(num) > khachHangList.Count())
            {
                Console.WriteLine("Mã khách hàng muốn tra cứu không hợp lệ.");
                return;
            }
            khachHangList[Convert.ToInt32(num)].InTTKhachHang();
            
        }

        public void XoaTTKhachHang()
        {
            Console.Write("Nhập mã khách hàng muốn xóa: ");
            string maKH = Console.ReadLine();
            string num = null;
            foreach (char kt in maKH)
            {
                if (char.IsNumber(kt))
                {
                    num += kt;
                }
            }
            if (num == null || Convert.ToInt32(num) == 0 || Convert.ToInt32(num) > khachHangList.Count())
            {
                Console.WriteLine("Mã khách hàng muốn xóa không hợp lệ.");
                return;
            }
            khachHangList.RemoveAt(Convert.ToInt32(num));
            Console.WriteLine("Đã xóa thành công.");
        }

        public void GuiTien()
        {
            Console.Write("Nhập mã khách hàng muốn gửi tiền: ");
            string maKH = Console.ReadLine();
            string num = null;
            foreach (char kt in maKH)
            {
                if (char.IsNumber(kt))
                {
                    num += kt;
                }
            }
            if (num == null || Convert.ToInt32(num) == 0 || Convert.ToInt32(num) > khachHangList.Count())
            {
                Console.WriteLine("Mã khách hàng muốn gửi tiền không hợp lệ.");
                return;
            }
            KhachHang kh = khachHangList[Convert.ToInt32(num)];
            Console.Write("Nhập tài khoản muốn gửi tiền: ");
            int maTK = Convert.ToInt32(Console.ReadLine());
            if (maTK == 0 || maTK > kh.GetTKS().Count())
            {
                Console.WriteLine("Tài khoản muốn gửi tiền không hợp lệ.");
                return;
            }
            TaiKhoan tk = kh.GetTKS()[maTK];
            Console.Write("Nhập số tiền muốn nạp vào: ");
            int tienNap = Convert.ToInt32(Console.ReadLine());
            tk.NapTien(tienNap);
        }

        public void RutTien()
        {
            Console.Write("Nhập mã khách hàng muốn rút tiền: ");
            string maKH = Console.ReadLine();
            string num = null;
            foreach (char kt in maKH)
            {
                if (char.IsNumber(kt))
                {
                    num += kt;
                }
            }
            if (num == null || Convert.ToInt32(num) == 0 || Convert.ToInt32(num) > khachHangList.Count())
            {
                Console.WriteLine("Mã khách hàng muốn rút tiền không hợp lệ.");
                return;
            }
            KhachHang kh = khachHangList[Convert.ToInt32(num)];
            Console.Write("Nhập tài khoản muốn rút tiền: ");
            int maTK = Convert.ToInt32(Console.ReadLine());
            if (maTK == 0 || maTK > kh.GetTKS().Count())
            {
                Console.WriteLine("Tài khoản muốn rút tiền không hợp lệ.");
                return;
            }
            TaiKhoan tk = kh.GetTKS()[maTK];
            Console.Write("Nhập số tiền muốn rút vào: ");
            int tienRut = Convert.ToInt32(Console.ReadLine());
            tk.RutTien(tienRut);
        }
    }
}
