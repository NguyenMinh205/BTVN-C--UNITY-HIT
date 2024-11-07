using System;
using System.Collections;

namespace BTVN
{
    internal class Bai2
    {
        public static void Main(string[] args)
        {
            ////Cách 1
            //Console.Write("Nhap chuoi cac dau ngoac: ");
            //string chuoiNgoac = Console.ReadLine();
            //int ngoacDonMo = 0, ngoacDonDong = 0, ngoacNhonMo = 0, ngoacNhonDong = 0, ngoacVuongMo = 0, ngoacVuongDong = 0;
            //for (int i = 0; i < chuoiNgoac.Length; i++)
            //{
            //    if (chuoiNgoac[i] == '(')
            //    {
            //        ngoacDonMo += 1;
            //    }
            //    else if (chuoiNgoac[i] == ')')
            //    {
            //        ngoacDonDong += 1;
            //    }
            //    else if (chuoiNgoac[i] == '{')
            //    {
            //        ngoacNhonMo += 1;
            //    }
            //    else if (chuoiNgoac[i] == '}')
            //    {
            //        ngoacNhonDong += 1;
            //    }
            //    else if (chuoiNgoac[i] == '[')
            //    {
            //        ngoacVuongMo += 1;
            //    }
            //    else
            //    {
            //        ngoacVuongDong += 1;
            //    }
            //    if ((ngoacDonMo < ngoacDonDong) || (ngoacNhonMo < ngoacDonDong) || (ngoacVuongMo < ngoacVuongDong))
            //    {
            //        Console.WriteLine("Sai");
            //        return;
            //    }
            //}
            //if ((ngoacDonMo - ngoacDonDong == 0) && (ngoacNhonMo - ngoacNhonDong == 0) && (ngoacVuongMo - ngoacVuongDong == 0))
            //{
            //    Console.WriteLine("Dung");
            //}
            //else
            //{
            //    Console.WriteLine("Sai");
            //}

            ////Cách 2
            Console.Write("nhap chuoi cac dau ngoac: ");
            string chuoi = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            //char[] chars = chuoi.ToCharArray();
            foreach (char i in chuoi)
            {
                if (i == '(' || i == '[' || i == '{')
                {
                    stack.Push(i);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        if ((i == ')' && stack.Peek() == '(') || (i == '}' && stack.Peek() == '{') || (i == ']' && stack.Peek() == '['))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("Sai");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sai");
                        return;
                    }
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Dung"); ;
            }
            else
            {
                Console.WriteLine("Sai");
            }
        }
    }
}
