using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_KeThua_DongVat
{
    public class Dv_AnThit : Dong_Vat
    {
        //thuoc tinh  -->ko co
        //phuong thuc
        //1.kt -->ko co
        //2.khoi tao
        public Dv_AnThit() { }// constructor
        public Dv_AnThit(string t) : base(t) { }
        public Dv_AnThit(Dv_AnThit t) : base(t) { }
        // get and set --> no problem
        // operator
        public override void introFood()
        {
            Console.WriteLine("my foot is thit tuoi !");
        }
    }
}
