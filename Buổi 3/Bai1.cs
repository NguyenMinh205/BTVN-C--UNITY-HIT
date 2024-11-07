namespace BTVN
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            //Vẽ hình chữ nhật
            Console.WriteLine("Ve hinh chu nhat");
            int chieuDai, chieuRong;
            Console.Write("Nhap chieu dai: ");
            chieuDai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            chieuRong = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= chieuRong; i++)
            {
                if (i == 1 || i == chieuRong)
                {
                    for (int j = 1; j <= chieuDai; j++)
                    {
                        Console.Write("*");
                    }    
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= chieuDai; j++)
                    {
                        if (j == 1 || j == chieuDai)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            //Vẽ tam giác cân
            int canhTGC;
            Console.Write("Nhap do dai canh ben: ");
            canhTGC = Convert.ToInt32(Console.ReadLine());
            int viTriVeTrai, viTriVePhai;
            viTriVeTrai = viTriVePhai = canhTGC;
            for (int i = 1; i <= canhTGC; i++)
            {
                if (i == canhTGC)
                {
                    for (int j = 1; j <= canhTGC * 2 - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= canhTGC * 2 - 1; j++)
                    {
                        if (j == viTriVeTrai || j == viTriVePhai)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                    viTriVeTrai--;
                    viTriVePhai++;
                }
            }
        }
    }
}
