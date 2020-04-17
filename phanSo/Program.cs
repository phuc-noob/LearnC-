using System;

namespace phanSo
{
    public class PhanSo
    {
        // thuoc tinh
        private int ms, ts;
        // method

        // 1.kiem tra rang buoc
        public bool KtMs(int m)
        {
            return (m != 0);
        }
        // 2.khoi tao
        // 2.1 khoi tao gia tri ban dau 0/1
        public void khoiTao()
        {
            ts = 0;
            ms = 1;
        }
        public void khoiTao(int m, int t)
        {
            if (KtMs(m))
            {
                ms = m;
                ts = t;
            }
            else
            {
                ms = 1;
                ts = 0;
            }
        }

        // 2.3 khoi tao phan so cho truoc
        public void khoiTao(PhanSo p)
        {
            ms = p.ms;
            ts = p.ts;
        }
        // 3.cap nhat thong tin 
        public void ganTuSo(int t)
        {
            ts = t;
        }
        public void ganMauSo(int m)
        {
            if (KtMs(m))
            {
                ms = m;
            }
        }
        // 4.xu ly tinh toan
        public void nhap()
        {
            Console.Write("nhap tu so: ");
            ts = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so :");
                ms = int.Parse(Console.ReadLine());
            } while (ms == 0);
        }
        public void xuat()
        {
            Console.Write(ts + "/" + ms);
        }
        // 5.cung cap thong tin
        public int docMs() { return ms; }
        public int docTs() { return ts; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            // 1.tao va nhap gia tri hai ps
            // 2.tinh tich va in ra gia tri
            // 3.rut gon phan so
            // 4.toi gian phan so
            // 5.nghich dao phan so hien tai
            // 6.tìm phan so nghich dao
            PhanSo a, b, t;
            nhap(out a, out b, out t);
            tich(a, b, ref t);
            double kq;
            Console.Write("tich :");
            t.xuat();
            Console.WriteLine("\n--------------");
            RutGon(ref t);
            t.xuat();
            kq = ToiGian(t);
            Console.WriteLine("\n--------------");
            Console.WriteLine("{0:0.00}",kq);
            NgDao(ref t);
            t.xuat();
            Console.WriteLine();
        }

        static void tich(PhanSo a, PhanSo b,ref PhanSo t)
        {
            t.ganMauSo(a.docMs() * b.docMs());
            t.ganTuSo(a.docTs() * b.docTs());
        }
        static int UcLn (int a,int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        static void nhap(out PhanSo a, out PhanSo b, out PhanSo t)
        {
            a = new PhanSo();
            b = new PhanSo();
            t = new PhanSo();
            Console.WriteLine("nhap ps a:");
            a.nhap();
            Console.WriteLine("nhap ps b:");
            b.nhap();
            Console.WriteLine("nhap ps t:");
            t.nhap();
        }
        static void RutGon(ref PhanSo a)
        {
            int Uc = UcLn(a.docMs(), a.docTs());
            a.ganTuSo( a.docTs() / Uc);
            a.ganMauSo(a.docMs() / Uc);
        }
        static double ToiGian(PhanSo a)
        {
            double b = (double)a.docTs() / (double)a.docMs();
            return b;
        }
        static void NgDao(ref PhanSo a)
        {
            int tam;
            tam = a.docTs();
            a.ganTuSo(a.docMs());
            a.ganMauSo(tam);
        }
    }
}
