using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_KeThua_DongVat
{
    public class Dong_Vat
    {
        //thuoc tinh
        protected string ten;
        //phuong thuc
        //1.kiem tra
        //2.khoi tao
        public Dong_Vat()
        {
            ten = "";
        }
        public Dong_Vat(string t)
        {
            ten = t;
        }
        public Dong_Vat(Dong_Vat r)
        {
            ten = r.ten;
        }
        // phuong thuc get and set
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        //xu ly and tinh toan
        public void introName()
        {
            Console.WriteLine("i am : "+ten);
        }
        public virtual void introFood() { }// chua viet vi chua bik thuc an cu the
        public virtual void sound() { }//chua bik sound 

    }
}
