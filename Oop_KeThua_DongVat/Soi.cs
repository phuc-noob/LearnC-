using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_KeThua_DongVat
{
    public class Soi : Dv_AnThit
    {
        //properti -->don't need
        //kt rang buoc -->no need
        //khoi tao
        public Soi() { } //Constructor
        public Soi(string t) : base(t) { }
        public Soi(Soi w) : base(w) { }
        // get and set -->i think don't need now
        //operator
        public override void sound()
        {
            Console.WriteLine("woooooo...");
        }
    }
}
