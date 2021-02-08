using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MUsteriAdi + "Eklendi.");
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.MUsteriAdi + "Güncellendi.");
        }
    }
}
