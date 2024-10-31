using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class bai1b
    {
        //Bai 1b
        public static void Main(string[] args)
        {
            //Bài 1a:
            Console.Write("Nhap bien do: ");
            double bienDo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Omega: ");
            double omega = Convert.ToDouble(Console.ReadLine());
            double phaDaoDong = Math.PI / 2; ;
            double chuKi = (2 * Math.PI) / omega;
            Console.Write("Nhap thoi gian duoc di: ");
            float thoiGian = Convert.ToSingle(Console.ReadLine());
            //Tính quãng đường đi được trong 1 chu kỳ
            double distanceIn1Cycle = 4 * bienDo;
            //Tính xem đi được bao nhiêu chu kỳ hoàn chỉnh
            int chuKiDiDuoc = (int)(thoiGian / chuKi);
            //Tính xem thời gian còn lại tỉ lệ bao nhiêu với chu kỳ
            float thoiGianConLai = Math.Abs(thoiGian - chuKiDiDuoc * (float)chuKi);
            //Tính góc quay mà vật A cần quay trong thời gian còn lại
            float gocQuay = (thoiGianConLai * 360) / (float)chuKi;
            //Cài đặt điều kiện để xét quãng đường đi được trong thời gian còn lại
            double distanceInRemainingTime = 0;
            if (gocQuay > 180)
            {
                distanceInRemainingTime = 2 * bienDo + bienDo * Math.Cos((gocQuay - 90) * Math.PI / 180);
            }
            else if (gocQuay == 180)
            {
                distanceInRemainingTime = 2 * bienDo;
            }
            else if (gocQuay == 90)
            {
                distanceInRemainingTime = bienDo;
            }
            else if (90 < gocQuay && gocQuay < 180)
            {
                distanceInRemainingTime = bienDo + bienDo * Math.Cos((gocQuay - 90) * Math.PI / 180);
            }
            else
            {
                distanceInRemainingTime = bienDo * Math.Cos((gocQuay * Math.PI) / 180);
            }
            //Kết quả
            double ketqua = distanceIn1Cycle * chuKiDiDuoc + bienDo + distanceInRemainingTime;
            Console.WriteLine("Dap an cua bai 1b: Tim quang duong ma vat A di duoc sau thoi gian t tinh tu thoi diem ban dau: " + ketqua);
        }
    }
}
