namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 2a:
            double vanToc = 20;
            double goc = (30 * Math.PI) / 180;
            //Vận tốc theo phương ngang
            double vPhuongNgang = vanToc * Math.Cos(goc);
            //Vận tốc theo phương thẳng đứng
            double vPhuongThangDung = vanToc * Math.Sin(goc);
            Console.WriteLine("Van toc theo phuong ngang la: " + vPhuongNgang);
            Console.WriteLine("Van toc theo phuong thang dung la: " + vPhuongThangDung);

            //Bài 2b: Thời gian vật lên đến điểm cao nhất
            double giaToc = 9.81;
            double thoiGianLenCaoNhat = (vanToc * Math.Sin(goc))/giaToc;
            Console.WriteLine("Thoi gian de vat len den diem cao nhat la: " + thoiGianLenCaoNhat);

            //Bài 2c: Chiều cao cực đại mà vật đạt được.
            double chieuCaoMax = (Math.Pow(vanToc, 2) * Math.Pow(Math.Sin(goc),2)) / (2*giaToc);
            Console.WriteLine("Chieu cao cuc dai ma vat dat duoc la: " + chieuCaoMax);

            //Bài 2d: Quãng đường ngang mà vật đã đi được khi rơi trở lại mặt đất (tầm ném xa)
            double tamNemXa = (Math.Pow(vanToc, 2) * Math.Pow(Math.Sin(goc), 2)) / giaToc;
            Console.WriteLine("Quang duong ngang ma vat da di duoc khi roi tro lai mat dat la: " + tamNemXa);
        }
    }
}
