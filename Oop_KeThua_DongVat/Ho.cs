using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_KeThua_DongVat
{
    public class Ho : Dv_AnThit
    {
        //properti
        //kt kieu kien
        //khoi tao
        public Ho() { }
        public Ho(string h) : base(h) { }
        public Ho(Ho h) : base(h) { }
        //get set
        //operator
        public override void sound()
        {
            Console.WriteLine("gummmmmmm....");
        }
    }
}
