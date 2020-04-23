using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_KeThua_DongVat
{
    public class Nai:Dv_AnChay
    {
        public Nai() { }
        public Nai(string n) : base(n) { }
        public Nai(Nai n) : base(n) { }
        public override void sound()
        {
            Console.WriteLine("naiiiiii....");
        }
    }
}
