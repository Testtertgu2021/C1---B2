using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1___B2
{
    //nhap so tu ban phim/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    class Sinhvien
    {
        string masv;
        double m1;
        double m2;
        double m3;
        public Sinhvien()
        {
            MSSV = "";
            M1 = 0;
            M2 = 0;
            M3 = 0;
        }
        public string MSSV
        {
            get { return masv; }
            set { masv = value; }
        }
        public double M1
        {
            get { return m1; }
            set { m1 = value; }

        }
        public double M2
        {
            get { return m2; }
            set { m2 = value; }
        }
        public double M3
        {
            get { return m3; }
            set { m3 = value; }
        }
        //nhap tu ban phim
        public void Nhap()
        {
            const int N = 3;
            int[] diem = new int[N];

            Console.WriteLine("\nNhap ma so sinh vien");
            MSSV = Console.ReadLine();

            Console.WriteLine("\nNhap diem mon 1");
            Double d;
            d = double.Parse(Console.ReadLine());
            if (d <= 0 || d > 100)
            {
                Console.WriteLine("\t Diem phai nam trong khoang 0 den 100");
                Console.Write("\tNhap lai diem mon 1");
                d = double.Parse(Console.ReadLine());
            }
            M1 = d;

            Console.WriteLine("\nNhap diem mon 2");
            d = double.Parse(Console.ReadLine());
            if (d <= 0 || d > 100)
            {
                Console.WriteLine("\t Diem phai nam trong khoang 0 den 100");
                Console.Write("\tNhap lai diem mon 2");
                d = double.Parse(Console.ReadLine());
            }
            M2 = d;

            Console.WriteLine("\nNhap diem mon 3");
            d = double.Parse(Console.ReadLine());
            if (d <= 0 || d > 100)
            {
                Console.WriteLine("\t Diem phai nam trong khoang 0 den 100");
                Console.Write("\tNhap lai diem mon 3");
                d = double.Parse(Console.ReadLine());
            }
            M3 = d;
        }
        public void xuat()
        {
            Console.WriteLine("{0,-15},{1,-15},{2,-15},{3,-15}", MSSV, M1, M2, M3);
        }



        static void Main(string[] args)
        {
            int N;
            Console.Write("nhap so luong sinh vien : ");
            N = int.Parse(Console.ReadLine());
         
            Sinhvien[] arrsv = new Sinhvien[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("nhap thong tin sinh vien thu {0}", (i + 1).ToString());
                arrsv[i] = new Sinhvien();
                arrsv[i].Nhap();
            }
            Console.WriteLine("\n Danh sach sinh vien");
            Console.WriteLine("{0,-15},{1,-15},{2,-15},{3,-15}", "Ma so sinh vien", "Mon 1", "Mon 2", "Mon 3");

            for (int j = 0; j < N; j++)
            {
                arrsv[j].xuat();
            }

        }
    }
}
