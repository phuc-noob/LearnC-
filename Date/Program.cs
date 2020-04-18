using System;

namespace Date
{
    class Program
    {
        public class MyDate
        {
            private int m_d, m_m, m_y;
            // 1.kiem tra rang buoc
            public bool KtYear(int m_y)
            {
                return (m_y > 0);
            }
            public bool KtMonth(int m_m)
            {
                return (m_m > 0 && m_m <= 12);
            }
            public bool KtDay(int d, int m, int y)
            {
                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        return (d <= 31);
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return (d <= 30);
                        break;
                    case 2:
                        if (nNhuan(y))
                        {
                            return (d <= 29);
                        }
                        else { return (d <= 28); }
                        break;
                    default:
                        return false;
                        break;
                }
                return true;
            }
            public bool nNhuan(int y)
            {
                if (y % 4 == 0 && y % 100 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // 2. khoi tao
            public void khoiTao()
            {
                m_d = 01;
                m_m = 01;
                m_y = 1000;
            }
            public void khoiTao(int d, int m, int y)
            {
                if (KtYear(y) && KtMonth(m) && KtDay(d, m, y)){
                    m_d = d;
                    m_m = m;
                    m_y = y;
                }
            }
            public void khoiTao(MyDate a)
            {
                m_d = a.m_d;
                m_m = a.m_m;
                m_y = a.m_y;
            }
            // 3.cap nhat thong tin
            public void Gan_d(int d) { m_d = d; }
            public void Gan_m(int m) { m_m = m; }
            public void Gan_y(int y) { m_y = y; }
            // 4. xu ly
            // 4.1 nhap ngay thang nam
            // 4.2 in ngay thang nam ra console
            // 4.3 so sanh ngaythangnam hien tai voi mot 
            // ngaythangnam khac
            // 4.4 tim thu cua ngaythangnam hien tai
            // 4.5 cong ngay thang hien tai voi 1 
            // ngaythangnam khac
            //5.cung cap thong tin
            public int Doc_d() { return m_d; }
            public int Doc_m() { return m_m; }
            public int Doc_y() { return m_y; }
            public void nhapD() 
            {
                do
                {
                    Console.Write("nhap vao nam :");
                    m_y = int.Parse(Console.ReadLine());
                } while (!KtYear(m_y));
                do
                {
                    Console.Write("nhap vao thang :");
                    m_m = int.Parse(Console.ReadLine());
                } while (!KtMonth(m_m));
                do
                {
                    Console.Write("nhap vao ngay:");
                    m_d = int.Parse(Console.ReadLine());
                } while (!KtDay(m_d, m_m, m_y));
            }
            public void xuatD()
            {
                Console.WriteLine("\n-------------");
                Console.Write("{0:00}/{1:00}/{2}",m_m,m_d,m_y);
            }
        }
        static void Main(string[] args)
        {
            MyDate a, b,c;
            c = new MyDate();
            nhapDate(out a);
            nhapDate(out b);
            c.khoiTao(a);
            kCach(a, b, ref c);
            a.xuatD();
            b.xuatD();
            c.xuatD();
            int kq = KcNgay(c);
            Console.WriteLine("\nngay :{0}", kq);
        }
        static void nhapDate(out MyDate a)
        {
            a = new MyDate();
            a.nhapD();
        }
        static void kCach(MyDate a,MyDate b,ref MyDate c)
        {
            c.Gan_d(a.Doc_d() - b.Doc_d());
            c.Gan_m(a.Doc_m() - b.Doc_m());
            c.Gan_y(a.Doc_y() - b.Doc_y());
        }
        static int KcNgay(MyDate c)
        {
            int m = c.Doc_m();
            int nNhuan = c.Doc_y() / 4;
            int kq = 0;
            do
            {
                if (m == 1 || m == 3 || m == 5
                    || m == 7 || m == 8
                    || m == 10 || m == 12)
                {
                    kq += m * 31;
                }
                else if (m == 4 || m == 6 || m == 9 || m == 11)
                {
                    kq += m * 30;
                }
                else if (m == 2 && c.KtYear(c.Doc_y()))
                {
                    kq += 29;
                }
                else { kq += 28; }
                --m;
            } while (m != 0);
            kq += (nNhuan * 366 + (c.Doc_y() - nNhuan) * 365);
            return (kq += c.Doc_d());
        }
    }
}
