using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Eklendi" + " " + musteri.Adi + " " + musteri.SoyAdi);
        }


        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Başarıyla Listelendi" + " " + musteri.Adi + " " + musteri.SoyAdi);
        }



        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi " + " " + musteri.Adi + " " + musteri.SoyAdi);
        }
    }
}
