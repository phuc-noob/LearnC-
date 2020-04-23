using System;

namespace Oop_KeThua_DongVat
{
    class Program
    {
        static void Main(string[] args)
        {
            // tao danh sach dong vat va cho chung
            // tu gioi thieu ve ban than
            Dong_Vat[] Arr = new Dong_Vat[5];
            KhoiTao(ref Arr);
            foreach(Dong_Vat d in Arr)
            {
                Console.WriteLine("--------");
                d.introName();
                d.sound();
                d.introFood();
            }
        }
        static void KhoiTao(ref Dong_Vat[] Arr)
        {
            Arr[0] = new De("De");
            Arr[1] = new Nai("Nai");
            Arr[2] = new Soi("Soi nau");
            Arr[3] = new Ho("Ho");
            Arr[4] = new Soi("soi xam");
        }
    }
}
