using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Musteriİslemleri
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri :" + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi : " + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi);
        } 
    }
}
