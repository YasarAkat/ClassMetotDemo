using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Akat";
            musteri1.Meslek = "Öğretmen";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Yaşar Mehmet";
            musteri2.Soyadi = "Akat";
            musteri2.Meslek = "Yazılımcı";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Azra";
            musteri3.Soyadi = "Akat";
            musteri3.Meslek = "Pilot";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID : " + musteri.Id);
                Console.WriteLine("Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
                Console.WriteLine("Müşteri Mesleği : " + musteri.Meslek);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("----------MÜŞTERİ EKLEME-SİLME-LİSTELEME İŞLEMLERİ-----------");
            Musteriİslemleri musteriİslemleri = new Musteriİslemleri();
            musteriİslemleri.Ekle(musteri1);
            musteriİslemleri.Ekle(musteri2);
            musteriİslemleri.Ekle(musteri3);

            musteriİslemleri.Sil(musteri1);
            musteriİslemleri.Sil(musteri2);
            

            
            musteriİslemleri.Listele(musteri3); 

            Console.WriteLine("Hello World!");
        }
    }
}
