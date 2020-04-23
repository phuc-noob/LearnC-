using System;

namespace Oop_KeThua
{
    // dinh nghia hinh - dai dien cho 1 khai niem hinh hoc noi chung
    public class hinh
    {
        // thuoc tinh
        protected int soDinh;
        //phuong thuc
        //1.kt rang buoc
        //2.khoi tao
        public hinh()
        {
            soDinh = 0;
        }
        public hinh(int d)
        {
            if (d > 0)
                soDinh = d;
            else
            {
                soDinh = 0;
            }
        }
        public hinh (hinh d)
        {
            soDinh = d.soDinh;
        }
        //3.cap nhat &cung cap thong tinh
        public int SoDinh
        {
            get { return soDinh; }
        }

        //4.xu ly tinh toan
        public virtual double hCv()
        {
            return 0; //chua bik la hinh gi
        }
        public virtual double hDt()
        {
            return 0;
        }
    }
    //dinh nghia lop chu nhat
    public class chuNhat : hinh
    {
        // thuoc tinh
        protected double cd, cr;
        // kt rang buoc
        public bool KtKhongAm(double a)
        {
            return a >= 0;
        }
        // khoi tao
        public chuNhat() : base(4)
        {
            cd = cr = 0;
        }
        public chuNhat(double c,double d) : base(4)
        {
            if (KtKhongAm(c) && KtKhongAm(d))
            {
                cd = c;
                cr = d;
            }
            else
            {
                cd = cr = 0;
            }
        }
        public chuNhat(chuNhat f) : base(4)
        {
            this.cd = f.cd;
            this.cr = f.cr;
        }
        // cap nhat & cung cap thong tin
        public double Cd
        {
            get { return cd; }
            set { if (KtKhongAm(value)) cd = value; }
        }
        public double Cr
        {
            get { return cr; }
            set { if (KtKhongAm(value)) cr = value; }
        }
        // xu ly tinh toan
        public override double hCv()
        {
            return 2 * (cd + cr);
        }
        public override double hDt()
        {
            return cd * cr;
        }
    }
    // dinh nghia lop hinh tron
    public class hinhTron : hinh
    {
        // thuoc tinh
        protected double bk;
        //kt rang buoc
        public bool KtkhongAm(double a)
        {
            return (a >= 0);
        }
        // khoi tao
        public hinhTron() : base(4)
        {
            bk = 0;
        }
        public hinhTron(double a) : base(4)
        {
            if (KtkhongAm(a))
                bk = a;
            else bk = 0;
        }
        public hinhTron(hinhTron f):base(4) 
        {
            bk = f.bk;
        }
        // cap nhat va cung cap thong tin
        public double Bk
        {
            get { return bk; }
            set { if (KtkhongAm(value)) bk = value; }
        }
        public override double hCv()
        {
            return 2 * Math.PI * bk;
        }
        public override double hDt()
        {
            return Math.PI * bk * bk;
        }
    }
    // dinh nghia lop tam giac
    public class tamGiac : hinh
    {
        // thuoc tinh 
        protected double a, b, c;
        // kt rang buoc
        public bool KtTg(double a,double b,double c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                return (a + b >= c && a + c >= b && b + c >= a);
            }
            else
            {
                return false;
            }
        }
        // khoi tao
        public tamGiac() : base(3)
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public tamGiac(double d,double f,double g):base(3)
        {
            if (KtTg(d,f,g))
            {
                a = d;
                b = f;
                c = g;
            }
            else
            {
                a = 0;
                b = 0;
                c = 0;
            }
        }
        public tamGiac(tamGiac f) : base(3)
        {
            a = f.a;
            b = f.b;
            c = f.c;
        }
        // cap nhat va cung cap thong tin
        public double A
        {
            get { return a; }
            set { if (KtTg(value, b, c)) a = value; }
        }
        public double B        {
            get { return b; }
            set { if (KtTg(a,value, c)) b = value; }
        }
        public double C
        {
            get { return c; }
            set { if (KtTg(a,b,value)) c = value; }
        }
        // xu ly va tinh toan
        public override double hCv()
        {
            return a + b + c;
        }
        public override double hDt()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    // dinh nghia lop hinh vuong
    public class hinhVuong : chuNhat
    {
        // thuoc tinh su dung cd and cr of hinh chu nhat
        // phuong thuc 
        // khoi tao
        public hinhVuong() { }
        public hinhVuong(double canh) : base(canh, canh) { }
        public hinhVuong(hinhVuong hv) : base(hv) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1.khai bao mang 5 hinh 
            // 2.tim vi tri va gia tri cua hinh co
            // chu vi hoac dien tich lon nhat
            hinh[] Arr = new hinh[5];
            Arr[0] = new chuNhat();
            Arr[1] = new hinhTron(1);
            Arr[2] = new tamGiac(8,9,10);
            Arr[3] = new hinhVuong(9);
            Arr[4] = new chuNhat(6,9);
            double MaxTamCv = Arr[0].hCv();
            double MaxTamDt = Arr[0].hDt();
            int vtCv = 0;
            int vtDt = 0;
            for(int i =1;i < Arr.Length; i++)
            {
                if (MaxTamCv < Arr[i].hCv()) { 
                    MaxTamCv = Arr[i].hCv();
                    vtCv = i;
                } 
                if(MaxTamDt < Arr[i].hDt())
                {
                    MaxTamDt = Arr[i].hDt();
                    vtDt = i;
                }
            }
            Console.WriteLine("dien tich tai {0} la max:{1}", vtDt, MaxTamDt);
            Console.WriteLine("chu vi tai {0} la max:{1}", vtCv, MaxTamCv);
        }
    }
}
