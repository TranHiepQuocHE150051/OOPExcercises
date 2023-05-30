using System;

namespace Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoPhuc a = new SoPhuc();
            SoPhuc b = new SoPhuc();
            int exit = 0;
            while (exit == 0)
            {
                try
                {
                    a = Nhap();
                    b = Nhap();
                    Tong2soPhuc(a, b);
                    Tich2soPhuc(a, b);
                    exit = 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhap sai! Ban phai nhap so!");
                }
            }
        }
        static void Tong2soPhuc(SoPhuc a, SoPhuc b)
        {
            SoPhuc tong = new SoPhuc();
            tong.PhanThuc = a.PhanThuc + b.PhanThuc;
            tong.PhanAo = a.PhanAo + b.PhanAo;
            Console.WriteLine("Tong :" + tong.PhanThuc + " + " + tong.PhanAo + "i");
        }
        public static void Tich2soPhuc(SoPhuc a, SoPhuc b)
        {
            SoPhuc tich = new SoPhuc();
            tich.PhanThuc = a.PhanThuc * b.PhanThuc - a.PhanAo * b.PhanAo;
            tich.PhanAo = a.PhanThuc * b.PhanAo + a.PhanAo * b.PhanThuc;
            Console.WriteLine("Tich :" + tich.PhanThuc + " + " + tich.PhanAo + "i");
        }
        public static SoPhuc Nhap()
        {
            SoPhuc so = new SoPhuc();
            Console.WriteLine("Nhap phan thuc");
            so.PhanThuc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap phan ao");
            so.PhanAo = Convert.ToDouble(Console.ReadLine());
            return so;
        }
    }
}
