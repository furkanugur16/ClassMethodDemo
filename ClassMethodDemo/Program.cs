using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1816;
            musteri1.Adi = "Furkan";
            musteri1.SoyAdi = "Uğur";
            musteri1.Yasi = 18;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 1345;
            musteri2.Adi = "Emir";
            musteri2.SoyAdi = "Uğur";
            musteri2.Yasi = 13;

            Musteri[] musteri = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine("Müşteri ID:" + " " + musteriler.Id);
                Console.WriteLine("Müşteri Adı:" + " " + musteriler.Adi);
                Console.WriteLine("Müşteri Soyadı: " + " " + musteriler.SoyAdi);
                Console.WriteLine("Müşteri Yaşı:" + " " + musteriler.Yasi);
            }
            Console.WriteLine("----------------------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("-----------------------------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            Console.WriteLine("------------------------------------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            Console.ReadLine();
        }
    }
}
