using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_KeThua_DongVat
{
    public class Dv_AnChay:Dong_Vat
    {
        //properti
        //kt rang buoc
        //khoi tao
        public Dv_AnChay() { }
        public Dv_AnChay(string t) :base(t){ }
        public Dv_AnChay(Dv_AnChay c) : base(c) { }
        //get and set 
        //operator
        public override void introFood()
        {
            Console.WriteLine("my foot is co...cay...hoa...la!!");
        }
    }
}
