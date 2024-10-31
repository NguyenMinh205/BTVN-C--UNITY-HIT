namespace bai1
{
    internal class bai1a
    {
        public static void Main(string[] args)
        {
            //Bài 1a:
            double bienDo = 9;
            double omega = 5 * Math.PI;
            double phaDaoDong = Math.PI / 2;
            double chuKi = (2 * Math.PI) / omega;
            float thoiGian = 2.125f;
            //Tính quãng đường đi được trong 1 chu kỳ
            double distanceIn1Cycle = 4 * bienDo;
            //Tính xem đi được bao nhiêu chu kỳ hoàn chỉnh
            int chuKiDiDuoc = (int)(thoiGian/chuKi);
            //Tính xem thời gian còn lại tỉ lệ bao nhiêu với chu kỳ
            float thoiGianConLai = thoiGian - chuKiDiDuoc * (float)chuKi;
            //Tính góc quay mà vật A cần quay trong thời gian còn lại
            float gocQuay = (thoiGianConLai * 360) / (float)chuKi;
            //Kết quả
            double ketqua = distanceIn1Cycle * chuKiDiDuoc + bienDo + bienDo * Math.Cos((gocQuay - 90) * Math.PI / 180);
            Console.WriteLine("Dap an cua bai 1a: Tim quang duong ma vat A di duoc sau 2.125 giay tinh tu thoi diem ban dau: " + ketqua);
        }
    }
}
