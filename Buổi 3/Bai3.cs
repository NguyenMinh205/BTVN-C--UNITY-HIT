using System;
using System.Collections.Generic;


namespace BTVN
{
    internal class Bai3
    {   
        //Thêm dữ liệu bán hàng mới. 
        public static void addData(Dictionary<string, Dictionary<string, int>> qlbh)
        {
            do
            {
                Console.Write("Nhap ho ten nhan vien: ");
                string ten = Console.ReadLine();
                qlbh[ten] = new Dictionary<string, int>();
                do
                {
                    Console.Write("Nhap ten san pham ma nhan vien do ban: ");
                    string tenSP = Console.ReadLine();
                    Console.Write("Nhap so luong san pham ban duoc: ");
                    int soLuong = Convert.ToInt32(Console.ReadLine());
                    qlbh[ten].Add(tenSP, soLuong);
                    Console.Write("Nhap tiep thong ke san pham cua nhan vien " + ten + " khong (1: co, 0: khong): ");
                    int check = Convert.ToInt32(Console.ReadLine());
                    if (check == 0)
                    {
                        break;
                    }
                }
                while (true);
                Console.Write("Ban co muon nhap thong tin cua nhan vien khac khong (1: co, 0: khong): ");
                int checkNhap = Convert.ToInt32(Console.ReadLine());
                if (checkNhap == 0)
                {
                    return;
                }
            }
            while(true);
        }

        public static void showData(Dictionary<string, Dictionary<string, int>> qlbh)
        {
            foreach (var i in qlbh)
            {
                Console.WriteLine("Ten: " + i.Key);
                foreach (var j in i.Value)
                {
                    Console.WriteLine("Ten san pham: " + j.Key);
                    Console.WriteLine("Soluong: " + j.Value);
                }    
                Console.WriteLine();
            }
        }
        //Tìm nhân viên bán được tổng số lượng sản phẩm nhiều nhất. 
        static void findStaff (Dictionary<string, Dictionary<string, int>> qlbh)
        {
            string nvMax = default;
            int slMax = 0;
            foreach (var i in qlbh)
            {
                int tong = 0;
                foreach (var j in i.Value)
                {
                    tong += j.Value;
                }
                if (tong > slMax) 
                { 
                    slMax = tong;
                    nvMax = i.Key;
                }
            }
            Console.WriteLine("Nhan vien ban duoc tong so luong san pham nhieu nhat la: " + nvMax);
        }

        //Tính sản phẩm bán chạy nhất dựa trên tổng số lượng bán ra từ tất cả các nhân viên.
        static void bestSelling (Dictionary<string, Dictionary<string, int>> qlbh)
        {
            Dictionary<string, int> tongHang = new Dictionary<string, int>();
            foreach (var i in qlbh)
            {
                foreach (var j in i.Value)
                {
                    int soLuong;
                    string khoa;
                    khoa = j.Key.ToLower();
                    soLuong = j.Value;
                    if (!tongHang.ContainsKey(khoa))
                    {
                        tongHang.Add(khoa, soLuong);
                    }
                    else
                    {
                        tongHang[khoa] = soLuong + tongHang[khoa];
                    }
                }
            }

            string bestSellingGoods = "";
            int max = 0;
            foreach (var i in tongHang)
            {
                if (i.Value > max)
                {
                    max = i.Value;
                    bestSellingGoods = i.Key;
                }    
            }
            Console.WriteLine("San pham ban chay nhat la: " + bestSellingGoods + " voi so luong la: " + max);
        }

        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> qlbh = new Dictionary<string, Dictionary<string, int>>();
            addData(qlbh);
            showData(qlbh);
            findStaff(qlbh);
            bestSelling(qlbh);
        }
    }
}
