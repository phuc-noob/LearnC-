using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_KeThua_DongVat
{
    public class De:Dv_AnChay
    {
        public De() { }
        public De(string d) : base(d) { }
        public De(De d) : base(d) { }
        public override void sound()
        {
            Console.WriteLine("beeeeee..e");
        }
    }
}
